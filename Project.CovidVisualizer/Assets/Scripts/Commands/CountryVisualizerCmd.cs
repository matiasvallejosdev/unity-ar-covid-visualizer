using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Infrastructure;
using UniRx;

namespace Commands
{
    public class CountryVisualizerCmd : ICommand
    {
        private StateData countryData;
        private IStatesGateway gateway;

        public CountryVisualizerCmd(StateData countryData, IStatesGateway gateway)
        {
            this.countryData = countryData;
            this.gateway = gateway;
        }

        public void Execute()
        {
            int[] ids = {};
            gateway.StateTurnData(ids)
                //.Do(x => countryData.OnInformation.OnNext(x))
                .Subscribe();
        } 
    }
}
