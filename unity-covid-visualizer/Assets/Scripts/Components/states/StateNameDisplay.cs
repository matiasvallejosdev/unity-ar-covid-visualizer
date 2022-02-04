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
            stateData.stateName
                .Subscribe(UpdateName)
                .AddTo(this);

            stateData.stateNick
                .Subscribe(UpdateNick)
                .AddTo(this);
        }

        void UpdateName(string name)
        {
            nameLabel.text = stateData.stateName.Value;
        }
        void UpdateNick(string name)
        {
            nickLabel.text = stateData.stateNick.Value;
        }
    }
}
