using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UnityEngine.XR.ARFoundation;
using UniRx;
using System;
using UnityEngine.XR.ARSubsystems;
using static UnityEngine.InputSystem.InputAction;

namespace Components
{    
    public class ARTapToPlace : MonoBehaviour
    {
        [Header("Container")]
        public GameObject parentFather;
        public GameContainer gameContainer;

        [Header("AR References")]
        public GameObject placeAnchor;
        //public GameObject placementIndicator;
        public Camera arCamera;
        public ARRaycastManager arOriginRaycast;

        [Header("Settings")]
        public PLAY_DEVICE playDevice;

        private Pose placementPose;
        private bool isActiveCountryManager = false;

        void Start()    
        {
            ARControlManager.Instance.Controls.Player.ToggleWorld.performed += ctx => Touch(ctx);
            //placementIndicator = Instantiate(placementIndicator, new Vector3(0,0,0), placementIndicator.transform.rotation);

            gameContainer.placementPoseValid.Value = playDevice == PLAY_DEVICE.Editor ? true : false;

            gameContainer.isCountryManagerOnScene
                .Subscribe(OnManagerStatusChange)
                .AddTo(this);
        }

        private void OnManagerStatusChange(bool isManagerActive)
        {
            isActiveCountryManager = isManagerActive;      
        }
        
        public void Touch(CallbackContext context)
        {
            if(!context.action.triggered){return;}

            if(gameContainer.placementPoseValid.Value && !isActiveCountryManager)
            {
                GameObject objectPlaced = Instantiate(gameContainer.countryManager.countryPrefab, placementPose.position, placementPose.rotation);
                objectPlaced.transform.SetParent(parentFather.transform);
            }
        }

        void Update()
        {
            if(isActiveCountryManager || playDevice == PLAY_DEVICE.Editor)
                return;
            
            UpdatePlacementPose();
            //UpdatePlacementIndicator();
        }

        private void UpdatePlacementPose()
        {
            var screenCenter = arCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
            var hits = new List<ARRaycastHit>();
            arOriginRaycast.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);

            gameContainer.placementPoseValid.Value = hits.Count > 0;
            if (gameContainer.placementPoseValid.Value) 
            {
                placementPose = hits[0].pose;

                var cameraForward = arCamera.transform.forward;
                var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
                placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            }
        }
    }

    public enum PLAY_DEVICE
    {
        Editor,
        Mobile
    }
}

