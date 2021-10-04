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
        public StringReactiveProperty countryNick;
        public StringReactiveProperty countryName;
        
        [Space]
        public IntReactiveProperty infoDeaths;
        public IntReactiveProperty infoPositives;
        public IntReactiveProperty infoTested;
        
        [Space]
        public BoolReactiveProperty countryFocus;
        public ISubject<bool> OnRefresh = new Subject<bool>();
    }
}