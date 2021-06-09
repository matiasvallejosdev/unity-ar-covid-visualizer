using System;
using UniRx;
using UnityEngine;
using UnityEditor;
using ViewModel;

namespace Infrastructure
{
    public class GlobalGateway : IGlobalTurnGateway
    {
        private protected string URL_DATA_COUNTRY = "http";

        public IObservable<GlobalInformation> GlobalTurnData(GlobalManager globalManager)        
        {
            GlobalInformation global = new GlobalInformation();
            global.countryGlobalInformation = new CountryGlobalInformation();
            global.worldInformation = new WorldInformation();

            global.countryGlobalInformation.totalDeaths = 10000;
            global.countryGlobalInformation.totalPositives = 20;
            global.countryGlobalInformation.totalTested = 3000;
            
            return Observable.Return(global)
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Get country("+globalManager.countryGlobalData.idCountry.ToString()+") data!"))
                    .Do(_ => Debug.Log("Get global world data!"));
        }
    }
}
