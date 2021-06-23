using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Game Container", menuName = "Data/Game Container")]
    public class GameContainer : ScriptableObject
    {
        public BoolReactiveProperty isCountryManagerOnScene;
        public CountryManager countryManager;
        public GlobalManager globalManager;
        public ISubject<bool> OnUpdate = new Subject<bool>();
    }
}
