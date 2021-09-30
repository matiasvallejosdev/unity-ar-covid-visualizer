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
                    Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentStateSelected.countryName);    
                }
                gameContainer.countryManager.currentStateSelected = null;  
                return;
            } 

            if(gameContainer.countryManager.currentStateSelected != countryHit)
            {
                if(gameContainer.countryManager.currentStateSelected != null)
                {
                    gameContainer.countryManager.currentStateSelected.countryFocus.Value = false;
                    Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentStateSelected.countryName);    
                }
                Debug.Log("Execute command: select is " + countryHit.countryName);
                countryHit.countryFocus.Value = focusStatus;       
                gameContainer.countryManager.currentStateSelected = countryHit;   
            }
        }
    }
}
