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
        public Transform stateTransform;
        public Transform stateDataTransform;
        
        [Header("Parameters")]
        [SerializeField] private const float speed = 5f;

        private float _offsetDirection;
        private Vector3 _maxScaleSection = Vector3.zero;
        private Vector3 _directionMovement = Vector3.zero;
        private Vector3 _desiredScaleSection = Vector3.zero; 

        void Start()
        {
            _directionMovement = stateTransform.localPosition;

            _maxScaleSection = stateDataTransform.localScale;
            _desiredScaleSection = Vector3.zero;
            stateData.OnFocus.Value = false;
            
            stateData.OnFocus
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
            
            stateDataTransform.localScale = Vector3.Lerp(stateDataTransform.localScale, _desiredScaleSection, 
                                                        Time.deltaTime * speed);
        }
    }
}
