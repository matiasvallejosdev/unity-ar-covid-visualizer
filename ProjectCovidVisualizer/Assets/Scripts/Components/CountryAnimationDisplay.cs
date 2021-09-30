using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ViewModel;
using System;

namespace Components
{
    public class CountryAnimationDisplay : MonoBehaviour
    {
        public GameContainer gameContainer;
        public Rigidbody[] rigidbodyCountry;
        [Range(0,3)] public float startDelay;
        private System.Random random = new System.Random();

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
                r.AddForce(Vector3.up * random.Next(20,150), ForceMode.Impulse);
            }
        }
    }
}
