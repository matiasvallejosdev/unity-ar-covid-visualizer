using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using TMPro;
using Utilities;

namespace Components
{  
    public class GlobalInformationDisplay : MonoBehaviour
    {
        public GameContainer gameContainer; 
        public TextMeshProUGUI deathLabel, testedLabel, casesLabel;
        public TextMeshProUGUI fontHttpLabel;

        void Start()
        {
            fontHttpLabel.text = "Fuente: " + gameContainer.globalManager.worldData.fontHttp;

            gameContainer.globalManager.worldData.deathsGlobal
                .Subscribe(OnChangeDeaths)
                .AddTo(this);
            
            gameContainer.globalManager.worldData.positivesGlobal
                .Subscribe(OnChangeCases)
                .AddTo(this);
            
            gameContainer.globalManager.worldData.recoveredGlobal
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
}

