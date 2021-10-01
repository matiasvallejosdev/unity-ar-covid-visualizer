using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using System.Linq;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System;
using Commands;

namespace Components
{
    [ExecuteInEditMode]
    public class ARGazeCameraSelect : MonoBehaviour
    {
        public GameContainer gameContainer;
        public GameCmdFactory gameCmdFactory;


        [Header("AR References")]
        [SerializeField] Camera _mainCamera;
        [SerializeField] ARRaycastManager _arOriginRaycast;
        [SerializeField] private LayerMask _layer;

        [Header("Config")]
        public bool unselectIntelligent;

        void Start()
        {
            // Unselect previous references
            gameCmdFactory.PerfomFocusCmd(gameContainer, gameContainer.countryManager.currentStateSelected, false).Execute();         
        }
        
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
                StateData countryHit = hit.transform.GetComponent<StateHit>().countryData;    
                gameCmdFactory.PerfomFocusCmd(gameContainer, countryHit, true).Execute();         
            }
            else 
            {
                if(unselectIntelligent)
                    gameCmdFactory.PerfomFocusCmd(gameContainer, gameContainer.countryManager.currentStateSelected, false).Execute();         
            }
        }
    }
}
