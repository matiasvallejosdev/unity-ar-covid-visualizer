using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using TMPro;

public class GlobalInformationDisplay : MonoBehaviour
{
    public GlobalData globalData; 
    public TextMeshProUGUI deathLabel, testedLabel, casesLabel;
    public TextMeshProUGUI fontHttpLabel;

    void Start()
    {
        fontHttpLabel.text = "Fuente: " + globalData.fontHttp;

        globalData.deathsGlobal
            .Subscribe(OnChangeDeaths)
            .AddTo(this);
        
        globalData.casesGlobal
            .Subscribe(OnChangeCases)
            .AddTo(this);
        
        globalData.testedGlobal
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
