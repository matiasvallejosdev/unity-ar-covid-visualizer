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
        public float scaleFactor;
        
        public void OnClick(bool isUp)
        {
            float normalizedScaleFactor = isUp ? scaleFactor : scaleFactor * -1; 
            factoryCmd.CountryContainerScale(gameContainer, normalizedScaleFactor).Execute();
        }
    }
}
