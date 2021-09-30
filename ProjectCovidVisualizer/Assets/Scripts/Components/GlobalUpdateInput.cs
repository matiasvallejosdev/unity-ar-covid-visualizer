using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Commands;

namespace Components
{
    public class GlobalUpdateInput : MonoBehaviour
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
            cmdFactory.TurnGlobalData(gameContainer).Execute();
        }

        void OnDisable()
        {
            if(gameContainer == null)
                return;
                
            gameContainer.isCountryManagerOnScene.Value = false;
        }
        void OnEnable()
        {
            gameContainer.isCountryManagerOnScene.Value = true;
        }   
    }
}
