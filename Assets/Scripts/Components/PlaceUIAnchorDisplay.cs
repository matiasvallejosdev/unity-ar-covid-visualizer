using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;
using System;

public class PlaceUIAnchorDisplay : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameObject placeAnchor;
    public TextMeshProUGUI placeLabel; 
    
    void Start()
    {
        gameContainer.isCountryManagerOnScene
            .Subscribe(OnCountryManagerOnScene)
            .AddTo(this);   
    }

    private void OnCountryManagerOnScene(bool countryOnScene)
    {
        placeAnchor.SetActive(!countryOnScene);
    }
}
