using System;
using System.Collections;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Infrastructure
{
    public interface IGlobalTurnGateway 
    {
        IObservable<Unit> GlobalSequentialLoad(GlobalManager globalManager);
    }
}
