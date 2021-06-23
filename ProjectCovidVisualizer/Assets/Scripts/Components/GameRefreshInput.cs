using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;

public class GameRefreshInput : MonoBehaviour
{
    public GameContainer gameContainer;
    public GameCmdFactory cmdFactory;

    public void OnClickRefresh()
    {
        cmdFactory.TurnRefreshData(gameContainer).Execute();
    }
}
