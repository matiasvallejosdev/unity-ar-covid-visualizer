using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;

namespace Components
{
    public class StateAnimationDisplay : MonoBehaviour
    {
        [Header("Data")]
        public StateData stateData;
        
        [Header("References")]
        [SerializeField] private Transform stateTransform;
        [SerializeField] private Transform stateSectionInformation;
        
        [Header("Parameters")]
        [SerializeField] private const float speed = 5f;

        private float _offsetDirection;
        private Vector3 _maxScaleSection = Vector3.zero;
        private Vector3 _directionMovement = Vector3.zero;
        private Vector3 _desiredScaleSection = Vector3.zero; 

        void Start()
        {
            _directionMovement = stateTransform.localPosition;

            _maxScaleSection = stateSectionInformation.localScale;
            _desiredScaleSection = Vector3.zero;
            stateData.countryFocus.Value = false;
            
            stateData.countryFocus
                .Subscribe(OnSelectedChange)
                .AddTo(this);
            
        }
        private void OnSelectedChange(bool isSelected)
        {
            if(isSelected)
            { 
                _desiredScaleSection = _maxScaleSection;
                _directionMovement.y = (stateTransform.localScale.y / 10);
            }
            else
            {   
                _desiredScaleSection = Vector3.zero;
                _directionMovement.y = 0;
            }
        }

        void Update()
        {     
            stateTransform.localPosition = Vector3.Lerp(stateTransform.localPosition, _directionMovement, Time.deltaTime * speed);
            
            stateSectionInformation.localScale = Vector3.Lerp(stateSectionInformation.localScale, _desiredScaleSection, 
                                                        Time.deltaTime * speed);
        }
    }
}
