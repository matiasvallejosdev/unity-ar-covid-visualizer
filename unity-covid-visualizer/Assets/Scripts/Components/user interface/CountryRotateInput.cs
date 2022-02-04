using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Commands;


namespace Components
{
    public class CountryRotateInput : MonoBehaviour
    {
        public GameCmdFactory gameCmdFactory;
        public GameContainer gameContainer;
        public float rotateFactor;
        
        public void OnClick(bool isRight)
        {
            var anchor = GameObject.FindGameObjectWithTag(gameContainer.countryManager.countryPrefab.tag);
            float rotateFactorNormalized = isRight ? rotateFactor : rotateFactor * -1;
            gameCmdFactory.CountryContainerRotate(anchor, rotateFactorNormalized).Execute();
        }
    }
}
