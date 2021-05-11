using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation
{
    [Serializable]
    public class GraphicAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private GraphicAnimationValue _startValue;
        [SerializeField] private GraphicAnimationValue _endValue;

        public GraphicAnimationValue StartValue => _startValue;
        public GraphicAnimationValue EndValue => _endValue;
    }
}