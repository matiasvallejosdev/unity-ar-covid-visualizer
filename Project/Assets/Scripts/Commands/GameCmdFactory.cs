using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Infrastructure;

[CreateAssetMenu(fileName = "New Character Factory", menuName = "Command Factory/Game")]
public class GameCmdFactory : ScriptableObject
{
    // Global Update Data
    public GlobalVisualizerCmd TurnGlobalData(GlobalManager globalManager, MonoBehaviour handlerInput)
    {
        return new GlobalVisualizerCmd(globalManager, new GlobalGateway(), handlerInput);
    }
    // Country Update Data
    public CountryVisualizerCmd TurnCountryData(CountryData countryData)
    {
        return new CountryVisualizerCmd(countryData, new CountryGateway());
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
    // Focus country
    public PerfomFocusCmd PerfomFocusCmd(CountryManager countryManager, CountryData countryHit, bool focusStatus)
    {
        return new PerfomFocusCmd(countryManager, countryHit, focusStatus);
    }
    // Console
    public PerfomConsoleCmd PerfomConsole(string input, string prefix, IEnumerable<IConsoleCommand> commands)
    {
        return new PerfomConsoleCmd(input, prefix, commands);
    }
    // Refresh data
    public RefreshDataCmd TurnRefreshData(GameContainer gameContainer)
    {
        return new RefreshDataCmd(gameContainer);
    }
}
