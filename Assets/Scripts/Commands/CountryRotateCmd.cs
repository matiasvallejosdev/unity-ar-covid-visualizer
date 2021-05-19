using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;

public class CountryRotateCmd : ICommand
{
    private CountryContainer countryContainer;
    private int rotateFactor;

    public CountryRotateCmd(CountryContainer countryContainer, int rotateFactor)
    {
        this.countryContainer = countryContainer;
        this.rotateFactor = rotateFactor;
    }
    public void Execute()
    {
        var rotate = GameObject.FindGameObjectWithTag(countryContainer.countryPrefab.tag);
        Vector3 desiredRotQ = new Vector3(rotate.transform.eulerAngles.x, rotateFactor, rotate.transform.eulerAngles.z);

        rotate.transform.Rotate(Vector3.up + desiredRotQ);
        Debug.Log("Rotate go");
    }
}
