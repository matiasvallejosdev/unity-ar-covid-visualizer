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
        _offsetDirection = countryTransform.position.y;
        _maxScaleSection = sectionInformation.localScale;
        _desiredScaleSection = Vector3.zero;
        
        countryData.countrySelected
            .Subscribe(OnSelectedChange)
            .AddTo(this);
    }
    private void OnSelectedChange(bool isSelected)
    {
        if(isSelected)
        { 
            _desiredScaleSection = _maxScaleSection;
            _directionMovement.y = (countryTransform.localScale.y / 10) + _offsetDirection;
        }
        else
        {   
            _desiredScaleSection = Vector3.zero;
            _directionMovement.y = 0 + _offsetDirection;
        }
    }

    void Update()
    {
        _directionMovement.x = countryTransform.position.x;
        _directionMovement.z = countryTransform.position.z;
        
        // PROBLEMS HERE WHEN OBJECT SCALE DOWN OR UP!
        countryTransform.position = Vector3.Lerp(countryTransform.position, _directionMovement, Time.deltaTime * speed);
        sectionInformation.localScale = Vector3.Lerp(sectionInformation.localScale, _desiredScaleSection, 
                                                    Time.deltaTime * speed);
    }
}
