using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "CountryMotion", menuName = "Data/Country Motion")]
    public class CountryMotion : ScriptableObject
    {
        public int delayInitialization;
        public int delayForce;
        public int minForce;
        public int maxForce;
        public string motionName;
    }
}
