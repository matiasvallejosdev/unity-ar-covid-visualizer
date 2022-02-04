using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Random=UnityEngine.Random;
using UniRx;

namespace Components
{
    public class CountryAnimation : MonoBehaviour
    {
        public GameContainer gameContainer;
        public CountryMotion countryMotion;

        public Animator countryAnimator;
        public Animator uiAnimator;
        
        void Start()
        {
            gameContainer.OnDataReceiver
                .Subscribe(ExecuteAnimation)
                .AddTo(this);
        }

        public void ExecuteAnimation(bool o)
        {
            StartCoroutine(Animation());
        }

        private IEnumerator Animation()
        {
            yield return new WaitForSeconds(countryMotion.delayInitialization);
            countryAnimator.SetTrigger(countryMotion.motionName);
            uiAnimator.SetTrigger(countryMotion.motionName);
        }
    }
}
