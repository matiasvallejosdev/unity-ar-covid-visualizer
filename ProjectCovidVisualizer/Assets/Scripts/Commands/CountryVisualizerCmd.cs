using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Infrastructure;
using UniRx;

public class CountryVisualizerCmd : ICommand
{
    private CountryData countryData;
    private ICountryTurnGateway gateway;

    public CountryVisualizerCmd(CountryData countryData, ICountryTurnGateway gateway)
    {
        this.countryData = countryData;
        this.gateway = gateway;
    }

    public void Execute()
    {
        gateway.StateTurnData(countryData.countryId)
            //.Do(x => countryData.OnInformation.OnNext(x))
            .Subscribe();
    } 
}
