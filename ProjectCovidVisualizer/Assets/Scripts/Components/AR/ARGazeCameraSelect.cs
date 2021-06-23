using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using System.Linq;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System;

[ExecuteInEditMode]
public class ARGazeCameraSelect : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory gameCmdFactory;


    [Header("AR References")]
    [SerializeField] Camera _mainCamera;
    [SerializeField] ARRaycastManager _arOriginRaycast;
    [SerializeField] private LayerMask _layer;

    void FixedUpdate()
    {
        GazeIteraction();
    }

    private void GazeIteraction()
    {
        RaycastHit hit;

        if(Physics.Raycast(_mainCamera.transform.position, _mainCamera.transform.forward, out hit, 1000, _layer))
        {
            Debug.DrawRay(_mainCamera.transform.position, _mainCamera.transform.forward, Color.green); 

            CountryData countryHit = hit.transform.GetComponent<CountryHitData>().countryData;    
            //Debug.Log("Gaze in: "+ countryHit.countryName);

            gameCmdFactory.PerfomFocusCmd(gameContainer.countryManager, countryHit, true).Execute();         
        }
        else 
        {
            gameCmdFactory.PerfomFocusCmd(gameContainer.countryManager, gameContainer.countryManager.currentCountrySelected, false).Execute();         
        }
    }
}
