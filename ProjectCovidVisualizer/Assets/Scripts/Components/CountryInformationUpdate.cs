using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using ViewModel;
using UniRx;
using Commands;

namespace Components
{
    public class CountryInformationUpdate : MonoBehaviour
    {
        public StateData countryData;
        public GameCmdFactory cmdFactory;

        void Start()
        {
        /*countryData.OnInformation
                .Subscribe(InformationDisplay)
                .AddTo(this);*/
        }

        /*private void InformationDisplay(StateInformation info)
        {
            countryData.infoDeaths.Value = info.deaths;
            countryData.infoPositives.Value = info.positives;
            countryData.infoTested.Value = info.tested;
        }*/
    }
}
