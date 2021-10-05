using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;

namespace Components
{
    public class StateInformationDisplay : MonoBehaviour
    {
        public StateData stateData;
        public TextMeshProUGUI deathLabel;
        public TextMeshProUGUI recoverLabel;
        public TextMeshProUGUI positivesLabel;

        void Start()
        {
            stateData.stateDeaths
                .Subscribe(UpdateDeath)
                .AddTo(this);

            stateData.statePositives
                .Subscribe(UpdatePositives)
                .AddTo(this);

            stateData.stateRecovered
                .Subscribe(UpdateRecovered)
                .AddTo(this);
        }

        void UpdateDeath(int value)
        {
            deathLabel.text = value.ToString();
        }
        void UpdatePositives(int value)
        {
            positivesLabel.text = value.ToString();
        }
        void UpdateRecovered(int value)
        {
            recoverLabel.text = value.ToString();
        }
    }
}
