using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Commands;
using ViewModel;

namespace Tests.Editor.Commands
{
    public class CountryVisualizerCmdShould
    {
        private GameObject _gameObject;

        [SetUp]
        public void SetUp()
        {
            _gameObject = new GameObject();
        }

        [Test, Ignore("Ignore States")]
        public void country_scale_positive()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;

            //var cmd = new CountryVisualizerCmd(gameContainer.countryManager.countryPrefab, 1);
        }
    }
}
