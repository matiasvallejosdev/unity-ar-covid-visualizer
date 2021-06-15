using System;
using UniRx;
using UnityEngine;
using UnityEditor;
using ViewModel;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;

namespace Infrastructure
{
    public class GlobalGateway : IGlobalTurnGateway
    {
        private protected string URL_DATA = "https://coronavirus-tracker-api.herokuapp.com/v2/";
        public GlobalInformation global;

        public IObservable<Unit> GlobalSequentialLoad(GlobalManager globalManager)
        {
            global = new GlobalInformation();
            global.worldInformation = new WorldInformation();
            global.countryGlobalInformation = new CountryGlobalInformation();

            return Observable.FromCoroutine<Unit>(observer => TurnGlobalData(observer, globalManager.countryGlobalData.codeCountry))
                                            .Do(_ => Debug.Log("Get global world data and global country data in " + URL_DATA));
        }

        IEnumerator TurnGlobalData(IObserver<Unit> observer, string countryCode)
        {
            // ToYieldInstruction can await observbale
            // World Global Data
            string worldDataURL = URL_DATA + "latest";
            UnityWebRequest coronavirusInfoRequest = UnityWebRequest.Get(worldDataURL);

            yield return coronavirusInfoRequest.SendWebRequest();

            if(coronavirusInfoRequest.result == UnityWebRequest.Result.ConnectionError || coronavirusInfoRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("(GlobalWorldInformation)UnityWebRequest: " + coronavirusInfoRequest.error);
                yield break;
            }

            var jSONNode = JSON.Parse(coronavirusInfoRequest.downloadHandler.text);
            var jsoNN = jSONNode["latest"];  
            global.worldInformation.totalDeaths = jsoNN["deaths"].AsInt;
            global.worldInformation.totalPositives = jsoNN["confirmed"].AsInt;
            global.worldInformation.totalRecovered = jsoNN["recovered"].AsInt;

            // Country Global Data
            string countryDataURL = URL_DATA + "locations?&country_code=" + countryCode;
            coronavirusInfoRequest = UnityWebRequest.Get(countryDataURL);

            yield return coronavirusInfoRequest.SendWebRequest();

            if(coronavirusInfoRequest.result == UnityWebRequest.Result.ConnectionError || coronavirusInfoRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("(GlobalCountryInformation)UnityWebRequest: " + coronavirusInfoRequest.error);
                yield break;
            }

            jSONNode = JSON.Parse(coronavirusInfoRequest.downloadHandler.text);
            jsoNN = jSONNode["latest"];
            global.countryGlobalInformation.totalDeaths = jsoNN["deaths"].AsInt;
            global.countryGlobalInformation.totalPositives =  jsoNN["confirmed"].AsInt;
            global.countryGlobalInformation.totalRecovered = jsoNN["recovered"].AsInt;
            
            observer.OnNext(Unit.Default); // push Unit or all buffer result.
            observer.OnCompleted();
        }
    }
}

