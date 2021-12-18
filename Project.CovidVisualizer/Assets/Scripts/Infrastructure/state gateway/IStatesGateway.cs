using System;
using UniRx;
using ViewModel;

namespace Infrastructure
{
    public interface IStatesGateway 
    {
        IObservable<Unit> StateSequentialLoad(StateData[] stateData);
        public Country country {get; set;}
    }
}
