using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;
using System;

public class GameScaleCmd : ICommand
{
    private int scaleFactor;
    private GameContainer gameContainer;

    public GameScaleCmd(GameContainer gameContainer, int scaleFactor)
    {
        this.gameContainer = gameContainer;
        this.scaleFactor = scaleFactor;
    }

    public void Execute()
    {
        var scale = GameObject.FindGameObjectWithTag(gameContainer.countryManager.countryPrefab.tag);
        if(scale == null)
            return;

        // Scale country
        scale.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor) * 1/6;
    }
}
