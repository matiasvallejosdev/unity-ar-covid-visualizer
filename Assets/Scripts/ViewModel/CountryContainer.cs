using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Country Container", menuName = "Data/Country Container")]
    public class CountryContainer : ScriptableObject
    {
        public GameObject countryPrefab;
        public CountryData[] countryData;
        public BoolReactiveProperty IsActive;
        public Subject<CountryData> OnCountryMotion = new Subject<CountryData>();
    }
}
