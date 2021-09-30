using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Commands;

namespace Components
{
    public class CountryManagerUpdateInformation : MonoBehaviour
    {
        public GameContainer gameContainer;
        public GameCmdFactory cmdFactory;
        
        void Start()
        {
            gameContainer.OnUpdate
                .Subscribe(OnUpdate)
                .AddTo(this);
        }

        private void OnUpdate(bool update)
        {
            UpdateCountryData();
        }

        void UpdateCountryData()
        {
            foreach(StateData data in gameContainer.countryManager.statesData)
                cmdFactory.TurnCountryData(data).Execute();
        }
    }
}
