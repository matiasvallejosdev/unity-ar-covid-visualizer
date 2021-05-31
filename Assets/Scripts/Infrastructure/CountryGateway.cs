using System;
using UniRx;
using UnityEngine;
using UnityEditor;

namespace Infrastructure
{
    public class CountryGateway : ICountryTurnGateway
    {
        public string URL_DATA_COUNTRY = "http";
        public IObservable<CountryInformation[]> WorldDataTurn(int idCountry)
        {
            CountryInformation[] worldData = new CountryInformation[0];

            return Observable.Return(worldData);
        }
        public IObservable<CountryInformation> CountryTurnData(int idCountry)
        {
            CountryInformation countryData = new CountryInformation();

            return Observable.Return(countryData);
        }

        public IObservable<StateInformation> StateTurnData(int idCountry)
        {
            StateInformation c = new StateInformation();

            c.deaths = 1000;
            c.tested = 10;
            c.positives = 2000;
            
            return Observable.Return(c)
                    .Delay(TimeSpan.FromMilliseconds(1000))
                    .Do(_ => Debug.Log("Get country("+idCountry+") data!"));
        }
    }
}
