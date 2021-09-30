using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;

namespace Commands
{    
    public class RefreshDataCmd : ICommand
    {
        private GameContainer gameContainer;

        public RefreshDataCmd(GameContainer gameContainer)
        {
            this.gameContainer = gameContainer;
        }

        public void Execute()
        {
            Debug.Log("Execute refresh data");
            gameContainer.OnUpdate.OnNext(true);
        }
    }
}
