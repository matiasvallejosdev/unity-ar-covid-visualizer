using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Commands;


namespace Components
{
    public class CountryRotateInput : MonoBehaviour
    {
        public GameCmdFactory factoryCmd;
        public GameContainer gameContainer;
        public float rotateFactor;
        
        public void OnClick(bool isRight)
        {
            float rotateFactorNormalized = isRight ? rotateFactor : rotateFactor * -1;
            factoryCmd.CountryContainerRotate(gameContainer, rotateFactorNormalized).Execute();
        }
    }
}
