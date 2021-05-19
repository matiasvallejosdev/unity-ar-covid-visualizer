using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class CountryScaleInput : MonoBehaviour
{
    public GameCmdFactory factoryCmd;
    public CountryContainer countryContainer;
    
    public void OnClick(int scaleFactor)
    {
        factoryCmd.CountryContainerScale(countryContainer, scaleFactor).Execute();
    }
}
