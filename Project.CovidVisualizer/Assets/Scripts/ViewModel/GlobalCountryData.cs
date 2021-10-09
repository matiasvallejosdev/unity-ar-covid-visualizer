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
        public string fontHttpGlobal;
        public string fontHttpVaccines;

        [Header("Reactive")]
        public IntReactiveProperty deathsCountry;
        public IntReactiveProperty positivesCountry;
        public IntReactiveProperty recoveredCountry;

        public LongReactiveProperty vaccineOneDosisCountry;
        public LongReactiveProperty vaccineTwoDosisCountry;
        public FloatReactiveProperty vaccinationRateCountry;
    }
}