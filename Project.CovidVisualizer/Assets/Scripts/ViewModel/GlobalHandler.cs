using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New global handler", menuName = "Data/Global Handler")]
    public class GlobalHandler : ScriptableObject
    {
        public GlobalWorldData worldData;
        public GlobalCountryData countryGlobalData;
    }
}
