using System;
using UniRx;
using UnityEngine;
using UnityEditor;

namespace Infrastructure
{
    public class CountryGateway : ICountryTurnGateway
    {
        public IObservable<CountryInformation> CountryTurn(int idCountry)
        {
            CountryInformation c = new CountryInformation();

            c.deaths = 1000;
            c.tested = 10;
            c.positives = 2000;
            
            return Observable.Return(c)
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Get country("+idCountry+") data!"));
        }
    }
}
