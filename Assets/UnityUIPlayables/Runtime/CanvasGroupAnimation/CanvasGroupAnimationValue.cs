using System;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.CanvasGroupAnimation
{
    [Serializable]
    public class CanvasGroupAnimationValue
    {
        [SerializeField] private float _alpha = 1.0f;

        public float Alpha => _alpha;
    }
}