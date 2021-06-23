using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;
using UniRx;
using ViewModel;

public class GlobalVisualizerCmd : ICommand
{
    private GlobalGateway globalGateway;
    private readonly MonoBehaviour handlerInput;
    private GlobalManager globalManager;

    public GlobalVisualizerCmd(GlobalManager globalManager, GlobalGateway globalGateway, MonoBehaviour handlerInput)
    {
        this.globalManager = globalManager;
        this.globalGateway = globalGateway;
        this.handlerInput = handlerInput;
    }

    public void Execute()
    {
        globalGateway.GlobalSequentialLoad(globalManager)
            .Do(_ => Debug.Log("Sequential load completed"))
            .Do(_ => globalManager.OnDataReceiver.OnNext(globalGateway.global))
            .Subscribe();
    }
}
