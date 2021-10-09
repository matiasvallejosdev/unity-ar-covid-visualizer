using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;
using System;
using Utilities;

namespace Components
{
    public class GlobalCountryDataDisplay : MonoBehaviour
    {
        public GameContainer gameContainer;
        public TextMeshProUGUI deathLabel, testedLabel, casesLabel;
        public TextMeshProUGUI countryLabel;
        public TextMeshProUGUI fontHttpLabel;

        void Start()
        {
            countryLabel.text = gameContainer.globalManager.countryData.nameCountry;
            fontHttpLabel.text = "Fuente: " + gameContainer.globalManager.countryData.fontHttpGlobal;

            gameContainer.globalManager.countryData.deathsCountry
                .Subscribe(OnChangeDeaths)
                .AddTo(this);
            
            gameContainer.globalManager.countryData.positivesCountry
                .Subscribe(OnChangeCases)
                .AddTo(this);
            
            gameContainer.globalManager.countryData.recoveredCountry
                .Subscribe(OnChangeTested)
                .AddTo(this);
        }

        private void OnChangeTested(int tested)
        {
            testedLabel.text = "Recovered: " + Utility.GetNumberFormat(tested);
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
