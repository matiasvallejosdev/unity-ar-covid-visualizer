using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using ViewModel;
using UniRx;
using System;

namespace Components
{
    public class CountryGraphDisplay : MonoBehaviour
    {
        public GameContainer gameContainer;
        public float WaitTime;

        [SerializeField] CountryBarDisplay deathBar;
        [SerializeField] CountryBarDisplay positiveBar;
        [SerializeField] CountryBarDisplay recoverBar;

        void Start() 
        {
            gameContainer.OnDataReceiver
                .Subscribe(OnDataUpdate)
                .AddTo(this);
        }

        void OnDataUpdate(bool u) 
        {
            StartCoroutine(MakeBarAnimation(
                gameContainer.globalManager.countryData.deathsCountry.Value, 
                gameContainer.globalManager.countryData.positivesCountry.Value, 
                gameContainer.globalManager.countryData.recoveredCountry.Value));
        }

        IEnumerator MakeBarAnimation(int death, int positives, int recovered) 
        {
            float maxNum = 10;
            float scale = ExtensionMethods.Remap(10, 0, maxNum, 0, 10);
            recoverBar.SetScale(scale);
            positiveBar.SetScale(scale);
            deathBar.SetScale(scale);

            yield return new WaitForSeconds(WaitTime);
            
            if(positives <= 0)
            {
                Debug.Log("[CountryGraphDisplay] Global information is null or zero");
                yield break;
            }

            maxNum = positives;
            
            float recoveredScale = ExtensionMethods.Remap(recovered, 0, maxNum, 0, 10);
            recoverBar.SetScale(recoveredScale);

            float positiveScale = ExtensionMethods.Remap(positives, 0, maxNum, 0, 10);
            positiveBar.SetScale(positiveScale);

            float deathScale = ExtensionMethods.Remap(death, 0, maxNum, 0, 10);
            deathBar.SetScale(deathScale);
        }
    }
}
