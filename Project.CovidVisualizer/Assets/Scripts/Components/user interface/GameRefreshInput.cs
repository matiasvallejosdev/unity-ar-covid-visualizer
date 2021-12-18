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

        public void OnClickRefresh()
        {
            gameContainer.OnUpdate.OnNext(true);
        }
    }
}
