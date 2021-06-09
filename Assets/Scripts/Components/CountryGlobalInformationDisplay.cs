using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;
using System;

public class CountryGlobalInformationDisplay : MonoBehaviour
{
    public CountryGlobalData countryGlobalData;
    public TextMeshProUGUI deathLabel, testedLabel, casesLabel;
    public TextMeshProUGUI countryLabel;
    public TextMeshProUGUI fontHttpLabel;

    void Start()
    {
        countryLabel.text = countryGlobalData.nameCountry;
        fontHttpLabel.text = "Fuente: " + countryGlobalData.fontHttp;

        countryGlobalData.deaths
            .Subscribe(OnChangeDeaths)
            .AddTo(this);
        
        countryGlobalData.cases
            .Subscribe(OnChangeCases)
            .AddTo(this);
        
        countryGlobalData.tested
            .Subscribe(OnChangeTested)
            .AddTo(this);
    }

    private void OnChangeTested(int tested)
    {
        testedLabel.text = "Tested: " + tested.ToString();
    }
    private void OnChangeCases(int cases)
    {
        casesLabel.text = "Cases: " + cases.ToString();
    }
    private void OnChangeDeaths(int deaths)
    {
        deathLabel.text = "Deaths: " + deaths.ToString();
    }
}
