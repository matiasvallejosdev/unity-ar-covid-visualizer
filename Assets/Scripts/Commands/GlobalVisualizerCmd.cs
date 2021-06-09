using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using UniRx;
using ViewModel;

public class GlobalVisualizerCmd : ICommand
{
    private GlobalGateway globalGateway;
    private GlobalManager globalManager;

    public GlobalVisualizerCmd(GlobalManager globalManager, GlobalGateway globalGateway)
    {
        this.globalManager = globalManager;
        this.globalGateway = globalGateway;
    }

    public void Execute()
    {
        globalGateway.GlobalTurnData(globalManager)
            .Do(x => globalManager.OnDataReceiver.OnNext(x))
            .Subscribe();;
    }
}
