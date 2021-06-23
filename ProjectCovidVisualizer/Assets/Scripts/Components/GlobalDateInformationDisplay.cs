using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using TMPro;
using UniRx.Triggers;
using UniRx;
using System;

public class GlobalDateInformationDisplay : MonoBehaviour
{
    public CountryGlobalData countryGlobalData;
    public TextMeshProUGUI countryLabel, fontHttpLabel;
    public TextMeshProUGUI dateNowLabel, timeNowLabel;
    
    void Start()
    {
        countryLabel.text = countryGlobalData.nameCountry;
        dateNowLabel.text = DateTime.Now.ToShortDateString();
        fontHttpLabel.text = "Fuente: " + countryGlobalData.fontHttp;
        
        this.gameObject.AddComponent<ObservableUpdateTrigger>()
            .LateUpdateAsObservable()
            .SampleFrame(60)
            .Subscribe(x => OnLateUpdate())
            .AddTo(this);
    }

    void OnLateUpdate()
    {
        timeNowLabel.text = DateTime.Now.ToShortTimeString().ToString();
    }
}
