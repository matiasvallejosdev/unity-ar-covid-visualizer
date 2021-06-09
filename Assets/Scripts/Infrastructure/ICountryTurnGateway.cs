using System;
using UniRx;

namespace Infrastructure
{
    public interface ICountryTurnGateway 
    {
        IObservable<StateInformation> StateTurnData(int idState);
    }
}
