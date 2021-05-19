using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;
using ViewModel;

namespace Components
{
    public class CountryInformationDisplay : MonoBehaviour
    {
        public TextMeshProUGUI deathLabel;
        public TextMeshProUGUI positivesLabel;
        public TextMeshProUGUI testedLabel;

        public CountryData countryData;

        void Start()
        {
            countryData.infoDeaths
                .Subscribe(UpdateDeathInfo)
                .AddTo(this);

            countryData.infoPositives
                .Subscribe(UpdatePositiveInfo)
                .AddTo(this);
            
            countryData.infoTested
                .Subscribe(UpdateTestedInfo)
                .AddTo(this);
        }

        void UpdateDeathInfo(int value)
        {
            deathLabel.text = value.ToString();
        }
        void UpdatePositiveInfo(int value)
        {
            positivesLabel.text = value.ToString();    
        }
        void UpdateTestedInfo(int value)
        {
            testedLabel.text = value.ToString();
        }
        
    }
}
