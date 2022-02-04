using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using ViewModel;
using UnityEngine;

namespace Components
{
    public class CountryUIAnchorDisplay : MonoBehaviour
    {
        public GameContainer gameContainer;
        public GameObject countryUIAnchor;
        
        public void Start()
        {
            gameContainer.isCountryManagerOnScene
                .Subscribe(OnCountryManagerOnScene)
                .AddTo(this);   
        }

        private void OnCountryManagerOnScene(bool countryOnScene)
        {
            countryUIAnchor.SetActive(countryOnScene);
        }
    }
}
