using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using ViewModel;
using UniRx;
using System;

public class CountryGraphDisplay : MonoBehaviour
{
    public GameContainer gameContainer;
    public float WaitTime;

    [SerializeField] CountryBarDisplay deathBar;
    [SerializeField] CountryBarDisplay positiveBar;
    [SerializeField] CountryBarDisplay recoverBar;

    void Start() 
    {
        gameContainer.globalManager.OnDataReceiver
            .Subscribe(OnDataRecieved)
            .AddTo(this);
    }

    void OnDataRecieved(GlobalInformation globalInformation) 
    {
        StartCoroutine(MakeBarAnimation(globalInformation));
    }

    IEnumerator MakeBarAnimation(GlobalInformation globalInformation) 
    {
        yield return new WaitForSeconds(WaitTime);

        if(globalInformation.countryGlobalInformation.totalPositives <= 0)
        {
            Debug.Log("(CountryGraphDisplay) Global information is null or zero");
            yield break;
        }
        float maxNum = globalInformation.countryGlobalInformation.totalPositives;
        
        float recoveredScale = ExtensionMethods.Remap(globalInformation.countryGlobalInformation.totalRecovered, 0, maxNum, 0, 10);
        recoverBar.SetScale(recoveredScale);

        float positiveScale = ExtensionMethods.Remap(globalInformation.countryGlobalInformation.totalPositives, 0, maxNum, 0, 10);
        positiveBar.SetScale(positiveScale);

        float deathScale = ExtensionMethods.Remap(globalInformation.countryGlobalInformation.totalDeaths, 0, maxNum, 0, 10);
        deathBar.SetScale(deathScale);
    }
}
