using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Game Container", menuName = "Data/Game Container")]
    public class GameContainer : ScriptableObject
    {
        public CountryManager countryManager;
        public GlobalManager globalManager;
        public BoolReactiveProperty placementPoseValid = new BoolReactiveProperty();
        public BoolReactiveProperty isCountryManagerOnScene;
        public ISubject<bool> OnUpdate = new Subject<bool>();
    }
}
