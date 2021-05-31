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
    public CountryVisualizerCmd TurnVirusData(CountryData[] countryData)
    {
        return new CountryVisualizerCmd(countryData, new CountryGateway());
    }

    public PerfomFocusCmd PerfomFocusCmd(CountryManager countryManager, CountryData countryHit, bool focusStatus)
    {
        return new PerfomFocusCmd(countryManager, countryHit, focusStatus);
    }

    // Ui Container Rotate&Scale
    public GameScaleCmd CountryContainerScale(GameContainer gameContainer, int scaleFactor)
    {
        return new GameScaleCmd(gameContainer, scaleFactor);
    }  
    public GameRotateCmd CountryContainerRotate(GameContainer gameContainer, int rotateFactor)
    {
        return new GameRotateCmd(gameContainer, rotateFactor);
    }
}
