using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Commands;

namespace Components
{
    public class CountryManagerController : MonoBehaviour
    {
        public GameContainer gameContainer;
        public GameCmdFactory cmdFactory;   

        void Start()
        {               
            gameContainer.isCountryManagerOnScene
                .Subscribe(OnCountryIsOnScene)
                .AddTo(this);
        }

        private void OnCountryIsOnScene(bool isOnScene)
        {
            if(!isOnScene)
            return;
            
            cmdFactory.TurnRefreshData(gameContainer).Execute();
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
