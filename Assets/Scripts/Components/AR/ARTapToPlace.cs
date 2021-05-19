using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UnityEngine.XR.ARFoundation;
using UnityEngine.InputSystem;
using UniRx;
using System;
using UnityEngine.XR.ARSubsystems;
using TouchPhase = UnityEngine.TouchPhase;

public class ARTapToPlace : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;

    public CountryContainer countryContainer;
    public GameObject placementIndicator;
    [SerializeField] ARRaycastManager arOriginRaycast;

    private Pose placementPose;
    private bool placementPoseValid = false;

    private bool isValidToPlace = true;

    void Awake()
    {
        //controls.Touch.TouchPress.performed += ctx => Touch(ctx);
    }

    public void Touch()
    {
        if(isValidToPlace && placementPoseValid)
        {
            GameObject objectPlaced = Instantiate(countryContainer.countryPrefab, placementPose.position, placementPose.rotation);
        }
    }

    void Start()
    {
        countryContainer.IsActive
            .Subscribe(OnContainerActive)
            .AddTo(this);
        
        placementIndicator = Instantiate(placementIndicator, new Vector3(0,0,0), placementIndicator.transform.rotation);
    }

    private void OnContainerActive(bool IsActive)
    {
        bool isValidToPlace = IsActive;
    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();

        if(Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Touch();
            }
        }
    }


    private void UpdatePlacementIndicator()
    {
        if (placementPoseValid) 
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else 
        {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arOriginRaycast.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseValid = hits.Count > 0;
        if (placementPoseValid) 
        {
            placementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }

    void OnEnable()
    {
        playerInput.enabled = true;
    }
    void OnDisable()
    {
        playerInput.enabled = false;
    }
}
