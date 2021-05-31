using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using ViewModel;

public class CountryVisualizerCmd : ICommand
{
    private CountryData[] countryData;
    private CountryGateway countryGateway;

    public CountryVisualizerCmd(CountryData[] countryData, CountryGateway countryGateway)
    {
        this.countryData = countryData;
        this.countryGateway = countryGateway;
    }
    
    public void Execute()
    {

    }
}
