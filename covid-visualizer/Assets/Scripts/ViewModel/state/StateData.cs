using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New State Data", menuName = "Data/State Data")]
    public class StateData : ScriptableObject
    {
        public int countryId;
        public StringReactiveProperty stateNick;
        public StringReactiveProperty stateName;
        
        [Space]
        public IntReactiveProperty stateDeaths;
        public IntReactiveProperty statePositives;
        public IntReactiveProperty stateRecovered;
        
        [Space]
        public BoolReactiveProperty OnFocus;
    }
}