using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using UniRx;
using UnityEngine.UI;
using System;
using UnityEngine.Video;
using TMPro;

namespace Components
{
    public class UIPlaceAnchorAnimationDisplay : MonoBehaviour
    {
        [Header("References")]
        public GameContainer gameContainer;
        public UXExperienceAR uxExperienceAR;

        [Header("Video player")]
        public RawImage videoRawImage;
        public TextMeshProUGUI tittleLabel;
        public VideoPlayer videoPlayer;

        public void Start()
        {
            gameContainer.isCountryManagerOnScene
                .Subscribe(OnCountryScene)
                .AddTo(this);

            gameContainer.placementPoseValid
                .Subscribe(OnPlacementValid)
                .AddTo(this);
                
            gameContainer.isCountryManagerOnScene.Value = false;
        }

        private void OnCountryScene(bool countryOnScene)
        {
            videoRawImage.gameObject.SetActive(!countryOnScene);
            tittleLabel.gameObject.transform.parent.gameObject.SetActive(!countryOnScene);
        }

        private void OnPlacementValid(bool poseValid)
        {
            if (poseValid)
            {
                // Tap to place video
                videoPlayer.clip = uxExperienceAR.videoClips[1];
                tittleLabel.text = uxExperienceAR.instructionsClips[1];
                videoRawImage.color = new Color(255, 255, 255, 1f);
            }
            else 
            {
                // Find to plane video
                videoPlayer.clip = uxExperienceAR.videoClips[0];
                tittleLabel.text = uxExperienceAR.instructionsClips[0];
                videoRawImage.color = new Color(255, 255, 255, 0f);
            }    
        }
    }
}
