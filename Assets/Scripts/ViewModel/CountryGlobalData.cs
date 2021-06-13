using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New country global", menuName = "Data/Country Global Data")]
    public class CountryGlobalData : ScriptableObject
    {
        [Header("Properties")]
        public int idCountry;
        public string codeCountry;
        public string nameCountry;
        public string fontHttp;

        [Header("Reactive")]
        public IntReactiveProperty deaths;
        public IntReactiveProperty positives;
        public IntReactiveProperty tested;
    }
}