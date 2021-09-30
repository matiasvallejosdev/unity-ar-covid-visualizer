using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Commands;


namespace Components
{
    public class GameRefreshInput : MonoBehaviour
    {
        public GameContainer gameContainer;
        public GameCmdFactory cmdFactory;

        public void OnClickRefresh()
        {
            cmdFactory.TurnGlobalData(gameContainer).Execute();
        }
    }
}
