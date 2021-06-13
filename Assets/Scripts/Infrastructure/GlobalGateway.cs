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
        private protected string URL_DATA_COUNTRY = "https://coronavirus-tracker-api.herokuapp.com/v2/";
        GlobalInformation global;
        
        public IObservable<GlobalInformation> GlobalTurnData(GlobalManager globalManager, MonoBehaviour handlerInput)        
        { 
            return Observable.Return(GetGlobalInformation(handlerInput, globalManager))
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Get global world data and global country data in " + URL_DATA_COUNTRY));
        }

        GlobalInformation GetGlobalInformation(MonoBehaviour handlerInput, GlobalManager globalManager)
        {
            global = new GlobalInformation();
            global.worldInformation = new WorldInformation();
            global.countryGlobalInformation = new CountryGlobalInformation();

            handlerInput.StartCoroutine(GetGlobalWorldInformation());
            handlerInput.StartCoroutine(GetGlobalCountryInformation(globalManager.countryGlobalData.codeCountry));

            return global;
        }

        IEnumerator GetGlobalWorldInformation()
        {
            string worldDataURL = URL_DATA_COUNTRY + "latest";
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
        }

        IEnumerator GetGlobalCountryInformation(string countryCode)
        {
            string worldDataURL = URL_DATA_COUNTRY + "locations?&country_code=" + countryCode;
            UnityWebRequest coronavirusInfoRequest = UnityWebRequest.Get(worldDataURL);

            yield return coronavirusInfoRequest.SendWebRequest();

            if(coronavirusInfoRequest.result == UnityWebRequest.Result.ConnectionError || coronavirusInfoRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("(GlobalCountryInformation)UnityWebRequest: " + coronavirusInfoRequest.error);
                yield break;
            }

            var jSONNode = JSON.Parse(coronavirusInfoRequest.downloadHandler.text);
            var jsoNN = jSONNode["latest"];
            
            global.countryGlobalInformation.totalDeaths = jsoNN["deaths"].AsInt;
            global.countryGlobalInformation.totalPositives =  jsoNN["confirmed"].AsInt;
            global.countryGlobalInformation.totalTested = jsoNN["recovered"].AsInt;
        }
    }
}
