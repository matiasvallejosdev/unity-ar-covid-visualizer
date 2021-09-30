using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;

namespace Components
{
    public class StateNameDisplay : MonoBehaviour
    {
        public TextMeshProUGUI nameLabel;
        public TextMeshProUGUI nickLabel;
        public StateData stateData;

        void Start()
        {
            stateData.countryName
                .Subscribe(UpdateName)
                .AddTo(this);

            stateData.countryNick
                .Subscribe(UpdateNick)
                .AddTo(this);
        }

        void UpdateName(string name)
        {
            nameLabel.text = stateData.countryName.Value;
        }
        void UpdateNick(string name)
        {
            nickLabel.text = stateData.countryNick.Value;
        }
    }
}
