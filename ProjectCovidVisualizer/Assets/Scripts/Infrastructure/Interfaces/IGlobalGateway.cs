using System;
using System.Collections;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Infrastructure
{
    public interface IGlobalGateway 
    {
        IObservable<Unit> GlobalSequentialLoad(GameContainer gameContainer);
        public Global globalData {get; set;}
    }
}
