using System;
using UniRx;

namespace Infrastructure
{
    public interface IStatesGateway 
    {
        public Country country {get; set;}
        IObservable<Unit> StateTurnData(int[] idStates);
    }
}
