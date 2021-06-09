using System;
using UniRx;
using ViewModel;

namespace Infrastructure
{
    public interface IGlobalTurnGateway 
    {
        IObservable<GlobalInformation> GlobalTurnData(GlobalManager globalManager);
    }
}
