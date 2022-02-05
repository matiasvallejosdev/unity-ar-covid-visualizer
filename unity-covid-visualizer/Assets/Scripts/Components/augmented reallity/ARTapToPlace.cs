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
        public GameContainer gameContainer;
        public GameObject parentContainer;
        public ARRaycastManager arOriginRaycast;

        private PLAY_DEVICE _playDevice;
        private Pose _placementPose;
        private Camera arCamera;

        void Start()    
        {
            arCamera = Camera.main;
            ARInputManager.Instance.Controls.Player.ToggleWorld.performed += ctx => Touch(ctx); // Input

            if (Application.isEditor)
            {
                _playDevice = PLAY_DEVICE.Editor;
            } 
            else
            {
                _playDevice = PLAY_DEVICE.Mobile;
            }

            gameContainer.placementPoseValid.Value = _playDevice == PLAY_DEVICE.Editor ? true : false;
        }
        
        void Touch(CallbackContext context)
        {
            if(!context.action.triggered){return;}
            PutCountry();
        }

        public void PutCountry()
        {
            if(gameContainer.placementPoseValid.Value && !gameContainer.isCountryManagerOnScene.Value)
            {
                GameObject objectPlaced = Instantiate(gameContainer.countryManager.countryPrefab, _placementPose.position, _placementPose.rotation);
                objectPlaced.transform.SetParent(parentContainer.transform);
            }
        }

        void Update()
        {
            if(gameContainer.isCountryManagerOnScene.Value || _playDevice == PLAY_DEVICE.Editor)
                return;
            
            UpdatePlacementPose();
        }

        private void UpdatePlacementPose()
        {
            var screenCenter = arCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
            var hits = new List<ARRaycastHit>();
            arOriginRaycast.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);

            gameContainer.placementPoseValid.Value = hits.Count > 0;
            if (gameContainer.placementPoseValid.Value) 
            {
                _placementPose = hits[0].pose;

                var cameraForward = arCamera.transform.forward;
                var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
                _placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            }
        }
    }

    public enum PLAY_DEVICE
    {
        Editor,
        Mobile
    }
}

