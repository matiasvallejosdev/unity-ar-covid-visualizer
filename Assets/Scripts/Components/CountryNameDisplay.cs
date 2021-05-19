using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using TMPro;
using ViewModel;

public class CountryNameDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameLabel;
    public TextMeshProUGUI nickLabel;
    public CountryData countryData;

    void Start()
    {
        countryData.countryName
            .Subscribe(UpdateName)
            .AddTo(this);

        countryData.countryNick
            .Subscribe(UpdateNick)
            .AddTo(this);
    }

    void UpdateName(string name)
    {
        nameLabel.text = countryData.countryName.Value;
    }
    void UpdateNick(string name)
    {
        nickLabel.text = countryData.countryNick.Value;
    }
}
