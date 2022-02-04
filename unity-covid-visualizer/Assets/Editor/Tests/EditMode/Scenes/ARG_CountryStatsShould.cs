using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.TestTools;
using Components;
using System.Threading.Tasks;

namespace Tests.Editor.Scenes
{    
    public class ARG_CountryStatsShould
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/ARG_CountryStats.unity");
            var component = Object.FindObjectOfType<ARTapToPlace>();
            component.PutCountry();
        }

        [Test]
        public void country_graph_display()
        {
            var component = Object.FindObjectOfType<CountryGraphDisplay>();
            component.Start();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.WaitTime);
        }

        [Test]
        public void country_rotate_input()
        {
            var component = Object.FindObjectOfType<CountryRotateInput>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.gameCmdFactory);
            Assert.GreaterOrEqual(component.rotateFactor,0);
        }

        [Test]
        public void country_scale_input()
        {
            var component = Object.FindObjectOfType<CountryScaleInput>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.gameCmdFactory);
            Assert.GreaterOrEqual(component.scaleFactor, 0);
        }

        [Test]
        public void country_ui_anchor_display()
        {
            var component = Object.FindObjectOfType<CountryUIAnchorDisplay>();
            component.Start();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.countryUIAnchor);
        }

        [Test]
        public void current_time_display()
        {
            var component = Object.FindObjectOfType<CurrentTimeDisplay>();
            component.Start();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.countryLabel);
            Assert.NotNull(component.fontHttpLabel);
            Assert.NotNull(component.dateNowLabel);
            Assert.NotNull(component.timeNowLabel);
        }

        [Test]
        public async void game_refresh_input()
        {
            await Task.Delay(300);
            var component = Object.FindObjectOfType<GameRefreshInput>();

            Assert.NotNull(component.gameContainer);
        }

        [Test]
        public void ui_place_anchor_animation_display()
        {
            var component = Object.FindObjectOfType<UIPlaceAnchorAnimationDisplay>();
            component.Start();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.uxExperienceAR);
            Assert.NotNull(component.videoRawImage);
            Assert.NotNull(component.tittleLabel);
            Assert.NotNull(component.videoPlayer);
        }

        [Test, Ignore("Need refactoring")]
        public void state_animation_display()
        {
            var components = Object.FindObjectsOfType<StateAnimationDisplay>();
            foreach (var component in components)
            {                
                component.Start();

                //Assert.NotNull(component.stateData);
                Assert.NotNull(component.stateTransform);
                Assert.NotNull(component.stateDataTransform);
            }
        }

        [Test]
        public void global_update_input()
        {
            var component = Object.FindObjectOfType<GlobalUpdateInput>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.gameCmdFactory);
        }

        [Test]
        public void global_world_data_display()
        {
            var component = Object.FindObjectOfType<GlobalWorldDataDisplay>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.casesLabel);
            Assert.NotNull(component.deathLabel);
            Assert.NotNull(component.testedLabel);
            Assert.NotNull(component.fontHttpLabel);
        }

        [Test]
        public void global_world_vaccine_data_display()
        {
            var component = Object.FindObjectOfType<GlobalWorldVaccineDataDisplay>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.rateLabel);
            Assert.NotNull(component.oneDoseLabel);
            Assert.NotNull(component.twoDoseLabel);
            Assert.NotNull(component.fontHttpLabel);
        }

        [Test]
        public void country_animation()
        {
            var component = Object.FindObjectOfType<CountryAnimation>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.countryMotion);
            Assert.NotNull(component.countryAnimator);
            Assert.NotNull(component.uiAnimator);
        }

        [Test]
        public void country_static_animation()
        {
            var component = Object.FindObjectOfType<CountryStaticAnimation>();
            component.Awake();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.countryMotion);
            Assert.NotNull(component.countryRigidbody);
        }

        [Test]
        public void global_country_data_display()
        {
            var component = Object.FindObjectOfType<GlobalCountryDataDisplay>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.casesLabel);
            Assert.NotNull(component.deathLabel);
            Assert.NotNull(component.testedLabel);
            Assert.NotNull(component.countryLabel);
            Assert.NotNull(component.fontHttpLabel);
        }

        [Test]
        public void global_country_vaccine_data_display()
        {
            var component = Object.FindObjectOfType<GlobalCountryVaccineDataDisplay>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.twoDoseLabel);
            Assert.NotNull(component.oneDoseLabel);
            Assert.NotNull(component.rateLabel);
            Assert.NotNull(component.countryLabel);
            Assert.NotNull(component.fontHttpLabel);
        }
        public void ar_tap_to_place()
        {
            var component = Object.FindObjectOfType<ARTapToPlace>();

            Assert.NotNull(component.parentFather);
            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.placeAnchor);
            Assert.NotNull(component.arCamera);
            Assert.NotNull(component.arOriginRaycast);
            Assert.NotNull(component.playDevice);
        }
        public void ar_gaze_camera_select()
        {
            var component = Object.FindObjectOfType<ARGazeCameraSelect>();

            Assert.NotNull(component.gameContainer);
            Assert.NotNull(component.gameCmdFactory);
        }
    }
}
