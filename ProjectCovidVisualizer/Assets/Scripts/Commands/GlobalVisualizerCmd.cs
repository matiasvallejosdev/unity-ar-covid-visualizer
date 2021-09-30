using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using UniRx;
using ViewModel;

namespace Commands
{    
    public class GlobalVisualizerCmd : ICommand
    {
        private IGlobalGateway globalGateway;
        private readonly GameContainer gameContainer;

        public GlobalVisualizerCmd(GameContainer gameContainer, IGlobalGateway globalGateway)
        {
            this.gameContainer = gameContainer;
            this.globalGateway = globalGateway;
        }

        public void Execute()
        {
            globalGateway.GlobalSequentialLoad(gameContainer)
                .Do(_ => Debug.Log("Sequential load completed"))
                .Do(_ => OnDataReceiver(gameContainer, globalGateway.globalData)) // Update data
                .Do(_ => gameContainer.globalManager.countryGlobalData.OnUpdate.OnNext(true))
                .Subscribe();
        }

        private void OnDataReceiver(GameContainer gameContainer, Global globalInformation)
        {       
            gameContainer.globalManager.countryGlobalData.positives.Value = globalInformation.globalCountryInfo.totalPositives;
            gameContainer.globalManager.countryGlobalData.recovered.Value = globalInformation.globalCountryInfo.totalRecovered;
            gameContainer.globalManager.countryGlobalData.deaths.Value = globalInformation.globalCountryInfo.totalDeaths;   
            gameContainer.globalManager.worldData.positivesGlobal.Value = globalInformation.globalWorldInfo.totalPositives;
            gameContainer.globalManager.worldData.recoveredGlobal.Value = globalInformation.globalWorldInfo.totalRecovered;
            gameContainer.globalManager.worldData.deathsGlobal.Value = globalInformation.globalWorldInfo.totalDeaths;
        }
    }
}
