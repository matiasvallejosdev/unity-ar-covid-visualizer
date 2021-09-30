using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using TMPro;
using UniRx.Triggers;
using UniRx;
using System;

namespace Components
{
    public class GlobalDateInformationDisplay : MonoBehaviour
    {
        public GameContainer gameContainer;
        public TextMeshProUGUI countryLabel, fontHttpLabel;
        public TextMeshProUGUI dateNowLabel, timeNowLabel;
        
        void Start()
        {
            countryLabel.text = gameContainer.globalManager.countryGlobalData.nameCountry;
            dateNowLabel.text = DateTime.Now.ToShortDateString();
            fontHttpLabel.text = "Fuente: " + gameContainer.globalManager.countryGlobalData.fontHttp;
            
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
}
