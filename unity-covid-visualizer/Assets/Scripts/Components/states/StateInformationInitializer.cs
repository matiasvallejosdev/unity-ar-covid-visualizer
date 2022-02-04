using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;

namespace Components
{
    public class StateInformationInitializer : MonoBehaviour
    {
        public StateData stateData;
        public StateInformationDisplay componentInformationDisplay;
        public StateNameDisplay componentStateNameDisplay;
        public StateAnimationDisplay componentStateAnimationDisplay;

        public Transform stateTransform;
        public Transform stateDataTransform;

        public void Awake()
        {
            InitalizeStateInformation();
        }

        void InitalizeStateInformation()
        {
            componentInformationDisplay.stateData = stateData;
            componentStateNameDisplay.stateData = stateData;
            componentStateAnimationDisplay.stateData = stateData;
            componentStateAnimationDisplay.stateDataTransform = stateDataTransform;
            componentStateAnimationDisplay.stateTransform = stateTransform;
        }
    }
}
