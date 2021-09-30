using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Infrastructure;

namespace Commands
{    
    [CreateAssetMenu(fileName = "New Character Factory", menuName = "Command Factory/Game")]
    public class GameCmdFactory : ScriptableObject
    {
        // Global Update Data
        public GlobalVisualizerCmd TurnGlobalData(GameContainer gameContainer)
        {
            return new GlobalVisualizerCmd(gameContainer, new GlobalGateway());
        }
        // Country Update Data
<<<<<<< HEAD
        public CountryVisualizerCmd TurnStateData(StateData countryData)
=======
        public CountryVisualizerCmd TurnCountryData(StateData countryData)
>>>>>>> 0cf034cc1f2fa7a52ce54bb5c14e6e2b11c6d0c0
        {
            return new CountryVisualizerCmd(countryData, new StatesArgentinaGateway());
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
        public PerfomFocusCmd PerfomFocusCmd(GameContainer gameContainer, StateData countryHit, bool focusStatus)
        {
            return new PerfomFocusCmd(gameContainer, countryHit, focusStatus);
        }
        // Console
        public PerfomConsoleCmd PerfomConsole(string input, string prefix, IEnumerable<IConsoleCommand> commands)
        {
            return new PerfomConsoleCmd(input, prefix, commands);
        }
<<<<<<< HEAD
=======
        // Refresh data
        public RefreshDataCmd TurnRefreshData(GameContainer gameContainer)
        {
            return new RefreshDataCmd(gameContainer);
        }
>>>>>>> 0cf034cc1f2fa7a52ce54bb5c14e6e2b11c6d0c0
    }
}
