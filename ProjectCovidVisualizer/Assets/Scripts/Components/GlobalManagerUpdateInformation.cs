using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using System;
using Infrastructure;

public class GlobalManagerUpdateInformation : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;
    
    void Start()
    {
        gameContainer.OnUpdate
            .Subscribe(OnUpdate)
            .AddTo(this);
    }

    private void OnUpdate(bool update)
    {
        UpdateGlobalData();
    }

    void UpdateGlobalData()
    {
        cmdFactory.TurnGlobalData(gameContainer.globalManager, this).Execute();
    }
}
