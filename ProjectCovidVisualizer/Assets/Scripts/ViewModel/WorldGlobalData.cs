using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New global data", menuName = "Data/Global Data")]
    public class WorldGlobalData : ScriptableObject
    {
        [Header("Properties")]
        public string fontHttp;
        
        [Header("Reactive")]
        public IntReactiveProperty recoveredGlobal;
        public IntReactiveProperty deathsGlobal;
        public IntReactiveProperty positivesGlobal;       
    }   
}
