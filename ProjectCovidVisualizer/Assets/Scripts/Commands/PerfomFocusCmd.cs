using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class PerfomFocusCmd : ICommand
{
    private CountryManager countryManager;
    private CountryData countryHit;
    private readonly bool focusStatus;

    public PerfomFocusCmd(CountryManager countryManager, CountryData countryHit, bool focusStatus)
    {
        this.countryManager = countryManager;
        this.countryHit = countryHit;
        this.focusStatus = focusStatus;
    }

    public void Execute()
    {
        if(focusStatus == false)
        {
            countryManager.OnCountryFocus.OnNext(null);
            return;
        }
        if(countryManager.currentCountrySelected == countryHit)
            return;
           
        Debug.Log("Execute command: select is " + countryHit.countryName);
        countryHit.countryFocus.Value = focusStatus;

        countryManager.OnCountryFocus.OnNext(countryHit);
    }
}
