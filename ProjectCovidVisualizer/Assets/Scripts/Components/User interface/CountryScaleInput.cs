using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Commands;


namespace Components
{
    public class CountryScaleInput : MonoBehaviour
    {
        public GameCmdFactory factoryCmd;
        public GameContainer gameContainer;
        
        public void OnClick(int scaleFactor)
        {
            factoryCmd.CountryContainerScale(gameContainer, scaleFactor).Execute();
        }
    }
}
