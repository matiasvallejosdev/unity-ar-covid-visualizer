using System;
using UniRx;
using UnityEngine;
using UnityEditor;

namespace Infrastructure
{
    public class CountryGateway : ICountryTurnGateway
    {
        private protected string URL_DATA_COUNTRY = "http://www.coronavirus.api/";

        public IObservable<StateInformation> StateTurnData(int idCountry)
        {
            StateInformation c = new StateInformation();

            c.deaths = 1000;
            c.tested = 10;
            c.positives = 2000;
            
            return Observable.Return(c)
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Get country data in " + URL_DATA_COUNTRY));
        }
    }
}
