using System;
using UniRx;
using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.Networking;

namespace Infrastructure
{
    public class StatesArgentinaGateway : IStatesGateway
    {
        private protected string URL_DATA = "http://www.coronavirus.api/";
        public Country country { get; set; }

        IObservable<Unit> IStatesGateway.StateTurnData(int[] idStates)
        {
            country = new Country(new CountryStatesInfo());

            //c.deaths = r.Next(0,10000000);
            //c.tested = r.Next(0,10000000);
            //c.positives = r.Next(0,10000000);
            
            return Observable.FromCoroutine<Unit>(observer => TurnStateData(observer, idStates))
                                            .Do(_ => Debug.Log("Get global world data and global country data in " + URL_DATA));
        }

        IEnumerator TurnStateData(IObserver<Unit> observer, int[] idStates)
        {
            // ToYieldInstruction can await observbale
            // States Argentina Data
            string worldDataURL = URL_DATA + "latest";
            UnityWebRequest coronavirusInfoRequest = UnityWebRequest.Get(worldDataURL);

            yield return coronavirusInfoRequest.SendWebRequest();

            if(coronavirusInfoRequest.result == UnityWebRequest.Result.ConnectionError || coronavirusInfoRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                //Debug.LogError("(GlobalWorldInformation)UnityWebRequest: " + coronavirusInfoRequest.error);
                yield break;
            }
        }

    }
}
