using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Infrastructure;

[CreateAssetMenu(fileName = "New Character Factory", menuName = "Command Factory/Game")]
public class GameCmdFactory : ScriptableObject
{
    public PerfomConsoleCmd PerfomConsole(string input, string prefix, IEnumerable<IConsoleCommand> commands)
    {
        return new PerfomConsoleCmd(input, prefix, commands);
    }
    public CountryTurnCmd CountryTurn(CountryData countryData)
    {
        return new CountryTurnCmd(countryData, new CountryGateway());
    }

    // Ui Container Rotate&Scale
    public CountryScaleCmd CountryContainerScale(CountryContainer countryContainer, int scaleFactor)
    {
        return new CountryScaleCmd(countryContainer, scaleFactor);
    }  
    public CountryRotateCmd CountryContainerRotate(CountryContainer countryContainer, int rotateFactor)
    {
        return new CountryRotateCmd(countryContainer, rotateFactor);
    }
}
