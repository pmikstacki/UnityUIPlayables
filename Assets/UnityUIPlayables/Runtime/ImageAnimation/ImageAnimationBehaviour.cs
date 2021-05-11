using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.ImageAnimation
{
    [Serializable]
    public class ImageAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private bool _controlColor;
        [SerializeField] private bool _controlFillAmount;
        [SerializeField] private ImageAnimationValue _startValue;
        [SerializeField] private ImageAnimationValue _endValue;

        public bool ControlColor => _controlColor;

        public bool ControlFillAmount => _controlFillAmount;

        public ImageAnimationValue StartValue => _startValue;
        public ImageAnimationValue EndValue => _endValue;
    }
}