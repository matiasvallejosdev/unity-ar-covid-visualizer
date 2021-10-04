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
        public string fontHttp;
        
        [Header("Reactive")]
        public IntReactiveProperty recoveredGlobal;
        public IntReactiveProperty deathsGlobal;
        public IntReactiveProperty positivesGlobal;       
    }   
}
