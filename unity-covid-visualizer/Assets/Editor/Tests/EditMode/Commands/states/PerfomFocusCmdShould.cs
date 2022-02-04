using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Commands;
using ViewModel;

namespace Tests.Editor.Commands
{
    public class PerfomFocusCmdShould
    {
        private GameObject _gameObject;

        [SetUp]
        public void SetUp()
        {
            _gameObject = new GameObject();
        }

        [Test]
        public void current_state_select()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            var state = ScriptableObject.CreateInstance<StateData>();
            state.countryId = 1;

            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;

            var cmd = new PerfomFocusCmd(gameContainer, state, true);
            cmd.Execute();
            
            Assert.AreEqual(state.countryId, gameContainer.countryManager.currentStateSelected.countryId);
        }

        [Test]
        public void current_state_unselect()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            var state = ScriptableObject.CreateInstance<StateData>();
            state.countryId = 1;

            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;
            gameContainer.countryManager.currentStateSelected = state;

            var cmd = new PerfomFocusCmd(gameContainer, state, false);
            cmd.Execute();

            Assert.IsNull(gameContainer.countryManager.currentStateSelected);
        }

        [Test]
        public void current_state_standby()
        {
            var gameContainer = ScriptableObject.CreateInstance<GameContainer>();
            var state = ScriptableObject.CreateInstance<StateData>();
            state.countryId = 1;

            gameContainer.countryManager = ScriptableObject.CreateInstance<CountryHandler>();
            gameContainer.countryManager.countryPrefab = _gameObject;
            gameContainer.countryManager.currentStateSelected = state;
    
            var cmd = new PerfomFocusCmd(gameContainer, state, true);
            cmd.Execute();

            Assert.IsNotNull(gameContainer.countryManager.currentStateSelected);
        }
    }
}
