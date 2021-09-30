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
<<<<<<< HEAD
            cmdFactory.TurnGlobalData(gameContainer).Execute();
=======
            cmdFactory.TurnRefreshData(gameContainer).Execute();
>>>>>>> 0cf034cc1f2fa7a52ce54bb5c14e6e2b11c6d0c0
        }
    }
}
