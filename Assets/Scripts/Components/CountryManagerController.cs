using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;

public class CountryManagerController : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;
    
    void Start()
    {
        gameContainer.countryManager.OnCountryFocus
            .Subscribe(OnCountryFocus)
            .AddTo(this);

        Quaternion look = new Quaternion(0, 180, 0, 1);
        this.gameObject.transform.rotation = look;
    }
    void UpdateCountryData()
    {
        foreach(CountryData data in gameContainer.countryManager.countryDataChildren)
            cmdFactory.CountryTurn(data).Execute();
    }

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

    void OnDisable()
    {
        gameContainer.isCountryManagerOnScene.Value = false;
    }
    void OnEnable()
    {
        gameContainer.isCountryManagerOnScene.Value = true;
        UpdateCountryData();
    }
}
