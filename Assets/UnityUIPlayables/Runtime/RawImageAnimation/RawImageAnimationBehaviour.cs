using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RawImageAnimation
{
    [Serializable]
    public class RawImageAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private bool _controlColor;
        [SerializeField] private bool _controlUvRect;
        [SerializeField] private RawImageAnimationValue _startValue;
        [SerializeField] private RawImageAnimationValue _endValue;

        public bool ControlColor => _controlColor;
        public bool ControlUvRect => _controlUvRect;
        public RawImageAnimationValue StartValue => _startValue;
        public RawImageAnimationValue EndValue => _endValue;
    }
}