using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Random=UnityEngine.Random;
using UniRx;

namespace Components
{
    public class CountryStaticAnimation : MonoBehaviour
    {
        public GameContainer gameContainer;
        public CountryMotion countryMotion;

        public Rigidbody countryRigidbody { get; set; }
        private Transform countryTransform { get; set;}

        private Vector3 startPosition;
        private Quaternion startRotation;
        
        
        public void Awake()
        {
            countryTransform = this.gameObject.GetComponent<Transform>();
            countryRigidbody = this.gameObject.GetComponent<Rigidbody>();
            startPosition = countryTransform.transform.localPosition;
            startRotation = countryTransform.transform.localRotation;
        }
        
        public void Start()
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
            StartPosition();
            yield return new WaitForSeconds(countryMotion.delayInitialization);
            countryRigidbody.isKinematic = false;

            yield return new WaitForSeconds(countryMotion.delayForce);
            countryRigidbody.AddForce(Vector3.up * Random.Range(countryMotion.minForce * 100, countryMotion.maxForce * 100), ForceMode.Force);
        }
        
        void StartPosition()
        {
            countryTransform.transform.localPosition = startPosition; 
            countryTransform.transform.localRotation = startRotation;

            countryRigidbody.isKinematic = true;
        }
    }
}
