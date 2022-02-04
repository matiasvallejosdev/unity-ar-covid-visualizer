using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Game Container", menuName = "Data/Game Container")]
    public class GameContainer : ScriptableObject
    {
        public GlobalHandler globalManager;
        public CountryHandler countryManager;
        public BoolReactiveProperty placementPoseValid = new BoolReactiveProperty();
        public BoolReactiveProperty isCountryManagerOnScene;
        public ISubject<bool> OnDataReceiver = new Subject<bool>();
        public ISubject<bool> OnUpdate = new Subject<bool>();
    }
}
