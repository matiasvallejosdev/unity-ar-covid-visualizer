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
    public class GlobalWorldVaccineDataDisplay : MonoBehaviour
    {
        public GameContainer gameContainer; 
        public TextMeshProUGUI rateLabel, oneDoseLabel, twoDoseLabel;
        public TextMeshProUGUI fontHttpLabel;

        void Start()
        {
            fontHttpLabel.text = "Fuente: " + gameContainer.globalManager.worldData.fontHttpVaccines;

            gameContainer.globalManager.worldData.vaccinationRateWorld
                .Subscribe(OnChangeRate)
                .AddTo(this);
            
            gameContainer.globalManager.worldData.vaccineOneDosisWorld
                .Subscribe(OnChangeOneDosis)
                .AddTo(this);
            
            gameContainer.globalManager.worldData.vaccineTwoDosisWorld
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

