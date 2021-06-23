using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class CountryScaleInput : MonoBehaviour
{
    public GameCmdFactory factoryCmd;
    public GameContainer gameContainer;
    
    public void OnClick(int scaleFactor)
    {
        factoryCmd.CountryContainerScale(gameContainer, scaleFactor).Execute();
    }
}
