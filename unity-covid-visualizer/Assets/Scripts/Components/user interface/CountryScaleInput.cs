using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Commands;


namespace Components
{
    public class CountryScaleInput : MonoBehaviour
    {
        public GameCmdFactory gameCmdFactory;
        public GameContainer gameContainer;
        public float scaleFactor;
        
        public void OnClick(bool isUp)
        {
            var anchor = GameObject.FindGameObjectWithTag(gameContainer.countryManager.countryPrefab.tag);
            float normalizedScaleFactor = isUp ? scaleFactor : scaleFactor * -1; 
            gameCmdFactory.CountryContainerScale(anchor, normalizedScaleFactor).Execute();
        }
    }
}
