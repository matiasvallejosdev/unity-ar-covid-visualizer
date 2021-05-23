using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;

public class CountryInformationController : MonoBehaviour
{
    [Header("Data")]
    public CountryData countryData;
    
    [Header("References")]
    [SerializeField] private Transform countryTransform;
    [SerializeField] private Transform sectionInformation;
    
    [Header("Parameters")]
    [SerializeField] private const float speed = 5f;

    private float _offsetDirection;
    private Vector3 _maxScaleSection = Vector3.zero;
    private Vector3 _directionMovement = Vector3.zero;
    private Vector3 _desiredScaleSection = Vector3.zero; 

    void Start()
    {
        _directionMovement = countryTransform.localPosition;

        _maxScaleSection = sectionInformation.localScale;
        _desiredScaleSection = Vector3.zero;
        
        countryData.countryFocus
            .Subscribe(OnSelectedChange)
            .AddTo(this);
        
        countryData.countryFocus.Value = false;
    }
    private void OnSelectedChange(bool isSelected)
    {
        if(isSelected)
        { 
            _desiredScaleSection = _maxScaleSection;
            _directionMovement.y = (countryTransform.localScale.y / 10);
        }
        else
        {   
            _desiredScaleSection = Vector3.zero;
            _directionMovement.y = 0;
        }
    }

    void Update()
    {     
        countryTransform.localPosition = Vector3.Lerp(countryTransform.localPosition, _directionMovement, Time.deltaTime * speed);
        
        sectionInformation.localScale = Vector3.Lerp(sectionInformation.localScale, _desiredScaleSection, 
                                                    Time.deltaTime * speed);
    }
}
