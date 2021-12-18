using System;
using UniRx;
using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.Networking;
using ViewModel;

namespace Infrastructure
{
    public class StatesArgentinaGateway : IStatesGateway
    {
        private protected string URL_DATA = "http://www.coronavirus.api/";
        public Country country { get; set; }

        public IObservable<Unit> StateSequentialLoad(StateData[] stateData)
        {
            country = new Country(new States());
            
            return Observable.FromCoroutine<Unit>(observer => TurnStateData(observer, stateData))
                                            .Do(_ => Debug.Log("Get global world data and global country data in " + URL_DATA));
        }

        IEnumerator TurnStateData(IObserver<Unit> observer, StateData[] stateData)
        {
            // ToYieldInstruction can await observbale
            // States Argentina Data
            yield return new WaitForSeconds(1);
            
            observer.OnNext(Unit.Default); // push Unit or all buffer result.
            observer.OnCompleted();
        }

    }
}
