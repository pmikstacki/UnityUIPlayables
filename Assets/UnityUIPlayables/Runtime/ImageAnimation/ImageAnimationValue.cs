using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.ImageAnimation
{
    [Serializable]
    public class ImageAnimationValue : GraphicAnimationValue
    {
        [SerializeField] private float _fillAmount = 1.0f;

        public float FillAmount => _fillAmount;
    }
}