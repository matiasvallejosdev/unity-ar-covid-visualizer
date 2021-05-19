using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;

public class CountryManager : MonoBehaviour
{
    public CountryContainer countryContainer;
    public GameCmdFactory cmdFactory;

    void UpdateCountryData()
    {
        foreach(CountryData country in countryContainer.countryData)
        {
            cmdFactory.CountryTurn(country).Execute();
        }
    }

    void OnDisable()
    {
        countryContainer.IsActive.Value = false;
    }
    void OnEnable()
    {
        countryContainer.IsActive.Value = true;
        UpdateCountryData();
    }
}
