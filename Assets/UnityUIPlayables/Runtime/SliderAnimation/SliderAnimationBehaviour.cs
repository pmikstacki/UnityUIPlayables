using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.SliderAnimation
{
    [Serializable]
    public class SliderAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private SliderAnimationValue _startValue;
        [SerializeField] private SliderAnimationValue _endValue;

        public SliderAnimationValue StartValue => _startValue;
        public SliderAnimationValue EndValue => _endValue;
    }
}