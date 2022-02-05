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
        public LayerMask layerInteraction;
        public bool unselectIntelligent;

        private Camera _arCamera;

        void Start()
        {
            _arCamera = Camera.main;
            gameCmdFactory.PerfomFocusCmd(gameContainer, gameContainer.countryManager.currentStateSelected, false).Execute();         
        }
        
        void FixedUpdate()
        {
            GazeIteraction();
        }

        private void GazeIteraction()
        {
            RaycastHit hit;

            if(Physics.Raycast(_arCamera.transform.position, _arCamera.transform.forward, out hit, 1000, layerInteraction))
            {
                Debug.DrawRay(_arCamera.transform.position, _arCamera.transform.forward, Color.green); 
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
