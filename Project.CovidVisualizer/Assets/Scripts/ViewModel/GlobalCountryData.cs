using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New country global data", menuName = "Data/Global Country Data")]
    public class GlobalCountryData : ScriptableObject
    {
        [Header("Properties")]
        public int idCountry;
        public string codeCountry;
        public string nameCountry;
        public string fontHttp;

        [Header("Reactive")]
        public IntReactiveProperty deaths;
        public IntReactiveProperty positives;
        public IntReactiveProperty recovered;

        public ISubject<bool> OnUpdate = new Subject<bool>();
    }
}