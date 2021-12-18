using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;
using System;

namespace Commands
{
    public class GameScaleCmd : ICommand
    {
        private float scaleFactor;
        private GameContainer gameContainer;

        public GameScaleCmd(GameContainer gameContainer, float scaleFactor)
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
}
