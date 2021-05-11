using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.CanvasGroupAnimation
{
    [Serializable]
    public class CanvasGroupAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private CanvasGroupAnimationValue _startValue;
        [SerializeField] private CanvasGroupAnimationValue _endValue;

        public CanvasGroupAnimationValue StartValue => _startValue;
        public CanvasGroupAnimationValue EndValue => _endValue;
    }
}