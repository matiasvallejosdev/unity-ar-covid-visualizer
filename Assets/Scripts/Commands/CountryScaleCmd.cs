using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;

public class CountryScaleCmd : ICommand
{
    private CountryContainer countryContainer;
    private int scaleFactor;

    public CountryScaleCmd(CountryContainer countryContainer, int scaleFactor)
    {
        this.countryContainer = countryContainer;
        this.scaleFactor = scaleFactor;
    }

    public void Execute()
    {
        // Scale Gameobject
        var scale = GameObject.FindGameObjectWithTag(countryContainer.countryPrefab.tag);
        scale.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor) * 1/6;
        Debug.Log("Scaling go");
    }
}
