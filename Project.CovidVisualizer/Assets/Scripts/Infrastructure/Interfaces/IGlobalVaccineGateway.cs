using System;
using System.Collections;
using UniRx;
using UnityEngine;
using ViewModel;

namespace Infrastructure
{
    public interface IGlobalVaccineGateway 
    {
        IObservable<Unit> GlobalSequentialLoad(GameContainer gameContainer);
        public GlobalVaccine globalVaccineData {get; set;}
    }
}
