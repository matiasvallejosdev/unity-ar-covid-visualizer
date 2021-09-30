using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

namespace Commands
{    
    public class PerfomFocusCmd : ICommand
    {
        private readonly GameContainer gameContainer;
        private StateData countryHit;
        private readonly bool focusStatus;

        public PerfomFocusCmd(GameContainer gameContainer, StateData countryHit, bool focusStatus)
        {
            this.gameContainer = gameContainer;
            this.countryHit = countryHit;
            this.focusStatus = focusStatus;
        }

        public void Execute()
        {
            if(!focusStatus)
            {
                if(gameContainer.countryManager.currentStateSelected != null)
                {
                    gameContainer.countryManager.currentStateSelected.countryFocus.Value = false;
<<<<<<< HEAD
                    //Debug.Log("[PerfomFocusCmd] Execute command unselect");    
=======
                    Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentStateSelected.countryName);    
>>>>>>> 0cf034cc1f2fa7a52ce54bb5c14e6e2b11c6d0c0
                }
                gameContainer.countryManager.currentStateSelected = null;  
                return;
            } 

            if(gameContainer.countryManager.currentStateSelected != countryHit)
            {
                if(gameContainer.countryManager.currentStateSelected != null)
                {
                    gameContainer.countryManager.currentStateSelected.countryFocus.Value = false;
<<<<<<< HEAD
                    //Debug.Log("[PerfomFocusCmd] Execute command unselect");    
                }
                //Debug.Log("[PerfomFocusCmd] Execute command select");    
=======
                    Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentStateSelected.countryName);    
                }
                Debug.Log("Execute command: select is " + countryHit.countryName);
>>>>>>> 0cf034cc1f2fa7a52ce54bb5c14e6e2b11c6d0c0
                countryHit.countryFocus.Value = focusStatus;       
                gameContainer.countryManager.currentStateSelected = countryHit;   
            }
        }
    }
}
