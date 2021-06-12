using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Infrastructure;

public class CountryManagerController : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;
    
    void Start()
    {
        gameContainer.countryManager.OnCountryFocus
            .Subscribe(OnCountryFocus)
            .AddTo(this);

        /*gameContainer.countryManager.OnDataReceiver
            .Subscribe(OnDataReceiver)
            .AddTo(this);*/
    }

   /*private void OnDataReceiver(CountryInformation countryDataReceiver)
    {
        foreach(StateInformation state in countryDataReceiver.statesChildren)
        {
            foreach(CountryData countryData in gameContainer.countryManager.countryDataChildren)
            {
                if(state.stateName == countryData.countryName.Value)
                {
                    countryData.OnInformation.OnNext(state);
                    break;
                }
            }
        }
    }*/

    private void OnCountryFocus(CountryData countrySelected)
    {
        if(gameContainer.countryManager.currentCountrySelected != countrySelected)
        {
            if(gameContainer.countryManager.currentCountrySelected != null)
            {
                gameContainer.countryManager.currentCountrySelected.countryFocus.Value = false;
                Debug.Log("Execute command: unselect is " + gameContainer.countryManager.currentCountrySelected.countryName);    
            }
            gameContainer.countryManager.currentCountrySelected = countrySelected;
        }
    }

    private void RefreshData()
    {
        cmdFactory.TurnRefreshData(gameContainer).Execute();
    }
    
    void OnDisable()
    {
        if(gameContainer == null)
            return;
            
        gameContainer.isCountryManagerOnScene.Value = false;
    }
    void OnEnable()
    {
        gameContainer.isCountryManagerOnScene.Value = true;
        Invoke("RefreshData", 0.3f);
    }
}
