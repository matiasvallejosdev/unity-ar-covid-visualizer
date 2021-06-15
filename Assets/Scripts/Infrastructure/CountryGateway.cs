using System;
using UniRx;
using UnityEngine;
using UnityEditor;

namespace Infrastructure
{
    public class CountryGateway : ICountryTurnGateway
    {
        private protected string URL_DATA_COUNTRY = "http://www.coronavirus.api/";

        System.Random r = new System.Random();

        public IObservable<StateInformation> StateTurnData(int idCountry)
        {
            StateInformation c = new StateInformation();
            
            //c.deaths = r.Next(0,10000000);
            //c.tested = r.Next(0,10000000);
            //c.positives = r.Next(0,10000000);
            
            return Observable.Return(c)
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Option country states are disable" + URL_DATA_COUNTRY));
        }
    }
}
