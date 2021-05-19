using System;
using UniRx;

namespace Infrastructure
{
    public interface ICountryTurnGateway 
    {
        IObservable<CountryInformation> CountryTurn(int data);
    }
}
