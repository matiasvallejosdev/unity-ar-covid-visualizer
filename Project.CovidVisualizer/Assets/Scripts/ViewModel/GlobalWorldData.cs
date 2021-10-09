using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New global world data", menuName = "Data/Global World Data")]
    public class GlobalWorldData : ScriptableObject
    {
        [Header("Properties")]
        public string fontHttpGlobal;
        public string fontHttpVaccines;
        
        [Header("Reactive")]
        public IntReactiveProperty recoveredGlobal;
        public IntReactiveProperty deathsGlobal;
        public IntReactiveProperty positivesGlobal; 

        public LongReactiveProperty vaccineOneDosisWorld;
        public LongReactiveProperty vaccineTwoDosisWorld;
        public FloatReactiveProperty vaccinationRateWorld;      
    }   
}
