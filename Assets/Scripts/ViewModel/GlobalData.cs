using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New global data", menuName = "")]
    public class GlobalData : ScriptableObject
    {
        public string fontHttp;
        public IntReactiveProperty testedGlobal;
        public IntReactiveProperty deathsGlobal;
        public IntReactiveProperty casesGlobal;
    }   
}
