using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using System;

public class CountryAnimationDisplay : MonoBehaviour
{
    public GameContainer gameContainer;
    public Rigidbody[] rigidbodyCountry;
    [Range(0,3)] public float startDelay;

    void Start()
    {
        gameContainer.isCountryManagerOnScene
            .Delay(TimeSpan.FromSeconds(startDelay))
            .Subscribe(ExecuteAnimation)
            .AddTo(this);
    }
    private void ExecuteAnimation(bool obj)
    {
        foreach(Rigidbody r in rigidbodyCountry)
        {
            r.isKinematic = false;
        }
    }
}
