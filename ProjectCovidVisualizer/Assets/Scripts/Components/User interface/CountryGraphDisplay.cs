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
            gameContainer.globalManager.countryGlobalData.OnUpdate
                .Subscribe(OnDataRecieved)
                .AddTo(this);
        }

        void OnDataRecieved(bool isUpdate) 
        {
            if(isUpdate)
                StartCoroutine(MakeBarAnimation(
                    gameContainer.globalManager.countryGlobalData.deaths.Value, 
                    gameContainer.globalManager.countryGlobalData.positives.Value, 
                    gameContainer.globalManager.countryGlobalData.recovered.Value));
        }

        IEnumerator MakeBarAnimation(int death, int positives, int recovered) 
        {
            yield return new WaitForSeconds(WaitTime);
            
            if(positives <= 0)
            {
                Debug.Log("(CountryGraphDisplay) Global information is null or zero");
                yield break;
            }
            float maxNum = positives;
            
            float recoveredScale = ExtensionMethods.Remap(recovered, 0, maxNum, 0, 10);
            recoverBar.SetScale(recoveredScale);

            float positiveScale = ExtensionMethods.Remap(positives, 0, maxNum, 0, 10);
            positiveBar.SetScale(positiveScale);

            float deathScale = ExtensionMethods.Remap(death, 0, maxNum, 0, 10);
            deathBar.SetScale(deathScale);
        }
    }
}
