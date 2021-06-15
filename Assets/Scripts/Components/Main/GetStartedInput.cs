using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEngine.SceneManagement;

public class GetStartedInput : MonoBehaviour
{
    public Button getStartedButton;
    public string sceneToCharge;
    
    void Start()
    {
        getStartedButton.OnClickAsObservable()
            .Subscribe(_ => LoadScene(sceneToCharge))
            .AddTo(this);
    }
    
    private protected void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        Debug.Log("Loading scene: " + sceneName);
    }
}

