using System;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.SliderAnimation
{
    [Serializable]
    public class SliderAnimationValue
    {
        [SerializeField] private float _value;

        public float Value => _value;
    }
}