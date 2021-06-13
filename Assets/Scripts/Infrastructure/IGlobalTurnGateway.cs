using System;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Infrastructure
{
    public interface IGlobalTurnGateway 
    {
        IObservable<GlobalInformation> GlobalTurnData(GlobalManager globalManager, MonoBehaviour handlerInput);
    }
}
