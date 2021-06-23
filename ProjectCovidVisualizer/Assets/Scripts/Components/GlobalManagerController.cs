using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using Infrastructure;
using System;

public class GlobalManagerController : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;

    void Start()
    {
        gameContainer.globalManager.OnDataReceiver
            .Subscribe(OnDataReceiver)
            .AddTo(this);
    }

    private void OnDataReceiver(GlobalInformation globalInformation)
    {       
        gameContainer.globalManager.countryGlobalData.positives.Value = globalInformation.countryGlobalInformation.totalPositives;
        gameContainer.globalManager.countryGlobalData.tested.Value = globalInformation.countryGlobalInformation.totalRecovered;
        gameContainer.globalManager.countryGlobalData.deaths.Value = globalInformation.countryGlobalInformation.totalDeaths;

        gameContainer.globalManager.worldData.positivesGlobal.Value = globalInformation.worldInformation.totalPositives;
        gameContainer.globalManager.worldData.recoveredGlobal.Value = globalInformation.worldInformation.totalRecovered;
        gameContainer.globalManager.worldData.deathsGlobal.Value = globalInformation.worldInformation.totalDeaths;
    }
}
