using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using TMPro;
using Utilities;

public class GlobalInformationDisplay : MonoBehaviour
{
    public WorldGlobalData globalData; 
    public TextMeshProUGUI deathLabel, testedLabel, casesLabel;
    public TextMeshProUGUI fontHttpLabel;

    void Start()
    {
        fontHttpLabel.text = "Fuente: " + globalData.fontHttp;

        globalData.deathsGlobal
            .Subscribe(OnChangeDeaths)
            .AddTo(this);
        
        globalData.positivesGlobal
            .Subscribe(OnChangeCases)
            .AddTo(this);
        
        globalData.recoveredGlobal
            .Subscribe(OnChangeTested)
            .AddTo(this);
    }
  
    private void OnChangeTested(int recovered)
    {
        testedLabel.text = "Recovered: " + Utility.GetNumberFormat(recovered);
    }
    private void OnChangeCases(int cases)
    {
        casesLabel.text = "Cases: " + Utility.GetNumberFormat(cases);
    }
    private void OnChangeDeaths(int deaths)
    {
        deathLabel.text = "Deaths: " + Utility.GetNumberFormat(deaths);
    }
}
