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
                // Case state focus input is false
                UnSelect();
                return;
            } 

            if(gameContainer.countryManager.currentStateSelected == countryHit)
                return;

            // Case state focus input is true
            UnSelect();
            gameContainer.countryManager.currentStateSelected = countryHit;            
            countryHit.OnFocus.Value = true;       
        }

        void UnSelect()
        {
            if(gameContainer.countryManager.currentStateSelected != null)
            {
                gameContainer.countryManager.currentStateSelected.OnFocus.Value = false;
            }
            // Case state focus input is false
            gameContainer.countryManager.currentStateSelected = null;  
        }
    }
}
