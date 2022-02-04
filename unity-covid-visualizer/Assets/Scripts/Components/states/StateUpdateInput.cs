using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Commands;

namespace Components
{
    public class StateUpdateInput : MonoBehaviour
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
            cmdFactory.TurnStateData(gameContainer, gameContainer.countryManager.statesData).Execute();
        }
    }
}
