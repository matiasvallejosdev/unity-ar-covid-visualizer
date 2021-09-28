using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class PerfomFocusCmd : ICommand
{
    private readonly GameContainer gameContainer;
    private CountryData countryHit;
    private readonly bool focusStatus;

    public PerfomFocusCmd(GameContainer gameContainer, CountryData countryHit, bool focusStatus)
    {
        this.gameContainer = gameContainer;
        this.countryHit = countryHit;
        this.focusStatus = focusStatus;
    }

    public void Execute()
    {
        if(!focusStatus)
        {
            if(gameContainer.countryManager.currentCountrySelected != null)
            {
                gameContainer.countryManager.currentCountrySelected.countryFocus.Value = false;
                Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentCountrySelected.countryName);    
            }
            gameContainer.countryManager.currentCountrySelected = null;  
            return;
        } 

        if(gameContainer.countryManager.currentCountrySelected != countryHit)
        {
            if(gameContainer.countryManager.currentCountrySelected != null)
            {
                gameContainer.countryManager.currentCountrySelected.countryFocus.Value = false;
                Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentCountrySelected.countryName);    
            }
            Debug.Log("Execute command: select is " + countryHit.countryName);
            countryHit.countryFocus.Value = focusStatus;       
            gameContainer.countryManager.currentCountrySelected = countryHit;   
        }
    }
}
