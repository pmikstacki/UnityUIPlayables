using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RawImageAnimation
{
    [Serializable]
    public class RawImageAnimationValue : GraphicAnimationValue
    {
        [SerializeField] private Rect _uvRect = new Rect(0, 0, 1, 1);

        public Rect UvRect => _uvRect;
    }
}