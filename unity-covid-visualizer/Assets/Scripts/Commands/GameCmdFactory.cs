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
            return new GlobalVisualizerCmd(gameContainer, new GlobalGateway(), new GlobalVaccineGateway());
        }
        // State Update Data
        public CountryVisualizerCmd TurnStateData(GameContainer gameContainer, StateData[] statesData)
        {
            return new CountryVisualizerCmd(gameContainer, statesData, new StatesArgentinaGateway());
        }
        // Ui Container Rotate&Scale
        public CountryScaleCmd CountryContainerScale(GameObject anchor, float scaleFactor)
        {
            return new CountryScaleCmd(anchor, scaleFactor);
        }  
        public CountryRotateCmd CountryContainerRotate(GameObject anchor, float rotateFactor)
        {
            return new CountryRotateCmd(anchor, rotateFactor);
        }
        // Focus country
        public PerfomFocusCmd PerfomFocusCmd(GameContainer gameContainer, StateData countryHit, bool focusStatus)
        {
            return new PerfomFocusCmd(gameContainer, countryHit, focusStatus);
        }
    }
}
