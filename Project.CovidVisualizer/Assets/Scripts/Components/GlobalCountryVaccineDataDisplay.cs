using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using TMPro;
using Utilities;
using System;

namespace Components
{  
    public class GlobalCountryVaccineDataDisplay : MonoBehaviour
    {
        public GameContainer gameContainer; 
        public TextMeshProUGUI countryLabel, rateLabel, oneDoseLabel, twoDoseLabel;
        public TextMeshProUGUI fontHttpLabel;

        void Start()
        {
            countryLabel.text = gameContainer.globalManager.countryData.nameCountry;
            fontHttpLabel.text = "Fuente: " + gameContainer.globalManager.countryData.fontHttpVaccines;

            gameContainer.globalManager.countryData.vaccinationRateCountry
                .Subscribe(OnChangeRate)
                .AddTo(this);
            
            gameContainer.globalManager.countryData.vaccineOneDosisCountry
                .Subscribe(OnChangeOneDosis)
                .AddTo(this);
            
            gameContainer.globalManager.countryData.vaccineTwoDosisCountry
                .Subscribe(OnChangeTwoDosis)
                .AddTo(this);
        }

        private void OnChangeTwoDosis(long num)
        {
            twoDoseLabel.text = "2 doses: " + Utility.GetNumberFormat(num);
        }

        private void OnChangeOneDosis(long num)
        {
            oneDoseLabel.text = "1 doses: " + Utility.GetNumberFormat(num);
        }

        private void OnChangeRate(float rate)
        {
            rateLabel.text = "% of population: " + rate.ToString() + "%";
        }
    }
}

