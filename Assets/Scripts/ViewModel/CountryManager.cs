using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Country Manager", menuName = "Data/Country Manager")]
    public class CountryManager : ScriptableObject
    {
        public GameObject countryPrefab;
        public CountryData[] countryDataChildren;
        public CountryData currentCountrySelected;
        public Subject<CountryData> OnCountryFocus = new Subject<CountryData>();
    }
}
