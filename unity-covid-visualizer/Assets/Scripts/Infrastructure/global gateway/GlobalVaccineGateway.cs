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
    public class GlobalVaccineGateway : IGlobalVaccineGateway
    {
        private protected string URL_DATA = "https://coronavirus-vaccines-api.herokuapp.com/v2/";
        public GlobalVaccine globalVaccineData {get; set;}

        public IObservable<Unit> GlobalSequentialLoad(GameContainer gameContainer)
        {
            globalVaccineData = new GlobalVaccine();

            return Observable.FromCoroutine<Unit>(observer => TurnGlobalData(observer, gameContainer.globalManager.countryData.codeCountry))
                                            .Do(_ => Debug.Log("Get global vaccination data in " + URL_DATA));
        }

        IEnumerator TurnGlobalData(IObserver<Unit> observer, string countryCode)
        {
            // ToYieldInstruction can await observbale
            // World & Country Vaccination  Data
            yield return new WaitForSeconds(1);

            globalVaccineData.worldPercentagePopulation = 35f;
            globalVaccineData.worldTotalOneDosis = 6440000000;
            globalVaccineData.worldTotalTwoDosis = 2730000000;

            globalVaccineData.countryPercentagePopulation = 51.5f;
            globalVaccineData.countryTotalOneDosis = 53000000;
            globalVaccineData.countryTotalTwoDosis = 23400000;

            observer.OnNext(Unit.Default); // push Unit or all buffer result.
            observer.OnCompleted();
        }
    }
}