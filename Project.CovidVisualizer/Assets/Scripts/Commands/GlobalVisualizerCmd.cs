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
        private readonly IGlobalVaccineGateway globalVaccineGateway;
        private readonly GameContainer gameContainer;

        public GlobalVisualizerCmd(GameContainer gameContainer, IGlobalGateway globalGateway, IGlobalVaccineGateway globalVaccineGateway)
        {
            this.gameContainer = gameContainer;
            this.globalGateway = globalGateway;
            this.globalVaccineGateway = globalVaccineGateway;
        }

        public void Execute()
        {
            // Get data world and country
            globalGateway.GlobalSequentialLoad(gameContainer)
                .Do(_ => Debug.Log("Sequential global load completed!"))
                .Do(_ => OnDataGlobalReceiver(gameContainer.globalManager.countryData, gameContainer.globalManager.worldData, globalGateway.globalData)) // Update data
                .Subscribe();
            
            // Get data world and country vaccines
            globalVaccineGateway.GlobalSequentialLoad(gameContainer)
                .Do(_ => Debug.Log("Sequential global vaccines load completed"))
                .Do(_ => OnDataGlobalVaccineReceiver(gameContainer.globalManager.countryData, gameContainer.globalManager.worldData, globalVaccineGateway.globalVaccineData)) // Update data
                .Subscribe();
            
            gameContainer.OnDataReceiver.OnNext(true);
        }

        private void OnDataGlobalReceiver(GlobalCountryData countryData, GlobalWorldData worldData, Global globalInformation)
        {       
            countryData.positivesCountry.Value = globalInformation.globalCountryInfo.totalPositives;
            countryData.recoveredCountry.Value = globalInformation.globalCountryInfo.totalRecovered;
            countryData.deathsCountry.Value = globalInformation.globalCountryInfo.totalDeaths;
               
            worldData.positivesGlobal.Value = globalInformation.globalWorldInfo.totalPositives;
            worldData.recoveredGlobal.Value = globalInformation.globalWorldInfo.totalRecovered;
            worldData.deathsGlobal.Value = globalInformation.globalWorldInfo.totalDeaths;
        }
        private void OnDataGlobalVaccineReceiver(GlobalCountryData countryData, GlobalWorldData worldData, GlobalVaccine globalInformation)
        {       
            countryData.vaccinationRateCountry.Value = globalInformation.countryPercentagePopulation;
            countryData.vaccineOneDosisCountry.Value = globalInformation.countryTotalOneDosis;
            countryData.vaccineTwoDosisCountry.Value = globalInformation.countryTotalTwoDosis;

            worldData.vaccinationRateWorld.Value = globalInformation.worldPercentagePopulation;
            worldData.vaccineOneDosisWorld.Value = globalInformation.worldTotalOneDosis;
            worldData.vaccineTwoDosisWorld.Value = globalInformation.worldTotalTwoDosis;
        }
    }
}
