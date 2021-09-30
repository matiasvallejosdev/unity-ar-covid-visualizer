using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New country handler", menuName = "Data/Country Handler")]
    public class CountryHandler : ScriptableObject
    {
        public GameObject countryPrefab;
        public StateData[] statesData;
        public StateData currentStateSelected;
    }
}
