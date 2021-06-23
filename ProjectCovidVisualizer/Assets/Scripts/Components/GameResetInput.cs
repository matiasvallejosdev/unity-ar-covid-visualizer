using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ViewModel;
using UniRx;

public class GameResetInput : MonoBehaviour
{
    public GameContainer gameContainer;
    public Button resetButton;
    
    void Start()
    {
        resetButton.OnClickAsObservable()
            .Subscribe(_ => ResetScene())
            .AddTo(this);
    }
    private void ResetScene()
    {
        if(gameContainer.isCountryManagerOnScene.Value == false)
            return;

        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);    
    }
}
