using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Commands;
using ViewModel;

namespace Tests.Editor.Commands
{
    public class CountryScaleCmdShould
    {
        private GameObject _gameObject;

        [SetUp]
        public void SetUp()
        {
            _gameObject = new GameObject();
        }

        [Test]
        public void country_scale_positive()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;

            var cmd = new CountryScaleCmd(gameContainer.countryManager.countryPrefab, 1);
            cmd.Execute();

            Assert.Greater(_gameObject.transform.localScale.y, 0);
        }

        [Test]
        public void country_scale_negative()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;

            var cmd = new CountryScaleCmd(gameContainer.countryManager.countryPrefab, -10);
            cmd.Execute();

            Assert.Less(_gameObject.transform.localScale.y, 0);
        }
    }
}
