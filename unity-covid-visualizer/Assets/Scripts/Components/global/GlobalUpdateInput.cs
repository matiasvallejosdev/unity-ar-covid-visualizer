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
        public GameCmdFactory gameCmdFactory;   

        public void Start()
        {
            gameContainer.OnUpdate
                .Subscribe(OnUpdate)
                .AddTo(this);
            
            gameContainer.OnUpdate.OnNext(true);
        }
        
        private void OnUpdate(bool update)
        {
            gameCmdFactory.TurnGlobalData(gameContainer).Execute();
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
