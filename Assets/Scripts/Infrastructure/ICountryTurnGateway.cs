using System;
using UniRx;

namespace Infrastructure
{
    public interface ICountryTurnGateway 
    {
        IObservable<CountryInformation[]> WorldDataTurn(int idCountry);
        IObservable<CountryInformation> CountryTurnData(int idCountry);
        IObservable<StateInformation> StateTurnData(int idState);
    }
}
