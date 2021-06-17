using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New global manager", menuName = "Data/Global Manager")]
    public class GlobalManager : ScriptableObject
    {
        public WorldGlobalData worldData;
        public CountryGlobalData countryGlobalData;
        public ISubject<GlobalInformation> OnDataReceiver = new Subject<GlobalInformation>();
    }
}
