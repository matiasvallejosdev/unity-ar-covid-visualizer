using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;

public class CountryManagerController : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;

    void UpdateCountryData()
    {
        foreach(CountryData data in gameContainer.countryManager.countryDataChildren)
            cmdFactory.CountryTurn(data).Execute();
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
