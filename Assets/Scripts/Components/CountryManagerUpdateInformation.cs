using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Infrastructure;

public class CountryManagerUpdateInformation : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;
    
    void Start()
    {
        gameContainer.OnUpdate
            .Subscribe(OnUpdate)
            .AddTo(this);
    }

    private void OnUpdate(bool update)
    {
        UpdateCountryData();
    }

    void UpdateCountryData()
    {
        Debug.Log("Update Country data");
        foreach(CountryData data in gameContainer.countryManager.countryDataChildren)
            cmdFactory.TurnCountryData(data).Execute();
    }
}
