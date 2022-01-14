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
        private readonly GameContainer gameContainer;
        private StateData[] statesData;
        private IStatesGateway statesGateway;

        public CountryVisualizerCmd(GameContainer gameContainer, StateData[] statesData, IStatesGateway gateway)
        {
            this.gameContainer = gameContainer;
            this.statesData = statesData;
            this.statesGateway = gateway;
        }

        public void Execute()
        {
            statesGateway.StateSequentialLoad(statesData)
                .Do(_ => Debug.Log("Sequential states load completed"))
                .Subscribe();
        }
    }
}
