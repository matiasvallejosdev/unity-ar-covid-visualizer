using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class CountryRotateInput : MonoBehaviour
{
    public GameCmdFactory factoryCmd;
    public CountryContainer countryContainer;
    
    public void OnClick(int rotateFactor)
    {
        factoryCmd.CountryContainerRotate(countryContainer, rotateFactor).Execute();
    }
}
