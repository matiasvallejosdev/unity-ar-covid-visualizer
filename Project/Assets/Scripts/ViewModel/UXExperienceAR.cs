using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Infrastructure;
using UnityEngine.Video;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New UxExperienceAR", menuName = "Data AR/UxExperience")]
    public class UXExperienceAR : ScriptableObject
    {
        public VideoClip[] videoClips;
        public string[] instructionsClips;
    }
}