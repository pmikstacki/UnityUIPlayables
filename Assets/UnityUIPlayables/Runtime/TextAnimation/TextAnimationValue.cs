using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextAnimation
{
    [Serializable]
    public class TextAnimationValue : GraphicAnimationValue
    {
        [SerializeField] private int _fontSize = 14;
        [SerializeField] private float _lineSpacing = 1.0f;

        public int FontSize => _fontSize;
        public float LineSpacing => _lineSpacing;
    }
}