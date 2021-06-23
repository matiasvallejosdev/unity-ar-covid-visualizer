using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class CountryRotateInput : MonoBehaviour
{
    public GameCmdFactory factoryCmd;
    public GameContainer gameContainer;
    
    public void OnClick(int rotateFactor)
    {
        factoryCmd.CountryContainerRotate(gameContainer, rotateFactor).Execute();
    }
}
