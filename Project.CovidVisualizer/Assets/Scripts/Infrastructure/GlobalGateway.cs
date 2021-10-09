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
    public class GlobalGateway : IGlobalGateway
    {
        private protected string URL_DATA = "https://coronavirus-tracker-api.herokuapp.com/v2/";
        public Global globalData {get; set;}

        public IObservable<Unit> GlobalSequentialLoad(GameContainer gameContainer)
        {
            globalData = new Global(new GlobalCountryInfo(), new GlobalWorldInfo());

            return Observable.FromCoroutine<Unit>(observer => TurnGlobalData(observer, gameContainer.globalManager.countryData.codeCountry))
                                            .Do(_ => Debug.Log("Get global data in " + URL_DATA));
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
            globalData.globalWorldInfo.totalDeaths = jsoNN["deaths"].AsInt;
            globalData.globalWorldInfo.totalPositives = jsoNN["confirmed"].AsInt;
            globalData.globalWorldInfo.totalRecovered = jsoNN["recovered"].AsInt;

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
            globalData.globalCountryInfo.totalDeaths = jsoNN["deaths"].AsInt;
            globalData.globalCountryInfo.totalPositives =  jsoNN["confirmed"].AsInt;
            globalData.globalCountryInfo.totalRecovered = jsoNN["recovered"].AsInt;
            
            observer.OnNext(Unit.Default); // push Unit or all buffer result.
            observer.OnCompleted();
        }
    }
}

