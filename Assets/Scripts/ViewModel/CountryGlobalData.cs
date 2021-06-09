using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New country global", menuName = "Data/CountryGlobalData")]
    public class CountryGlobalData : ScriptableObject
    {
        [Header("Properties")]
        public string nameCountry;
        public string fontHttp;

        [Header("Reactive")]
        public IntReactiveProperty deaths;
        public IntReactiveProperty cases;
        public IntReactiveProperty tested; 
    }
}