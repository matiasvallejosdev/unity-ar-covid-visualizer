using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;

public class GameRotateCmd : ICommand
{
    private int rotateFactor;
    private GameContainer gameContainer;

    public GameRotateCmd(GameContainer gameContainer, int rotateFactor)
    {
        this.gameContainer = gameContainer;
        this.rotateFactor = rotateFactor;
    }

    public void Execute()
    {
        var rotate = GameObject.FindGameObjectWithTag(gameContainer.countryManager.countryPrefab.tag);
        if(rotate == null)
            return;
        
        // Rotate country
        rotate.transform.RotateAround(rotate.transform.position, Vector3.up, rotateFactor);
    }
}
