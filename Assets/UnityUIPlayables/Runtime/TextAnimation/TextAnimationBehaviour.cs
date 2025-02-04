using System;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextAnimation
{
    [Serializable]
    public class TextAnimationBehaviour : AnimationBehaviour
    {
        [SerializeField] private bool _controlColor;
        [SerializeField] private bool _controlFontSize;
        [SerializeField] private bool _controlLineSpacing;
        [SerializeField] private TextAnimationValue _startValue;
        [SerializeField] private TextAnimationValue _endValue;

        public bool ControlColor => _controlColor;
        public bool ControlFontSize => _controlFontSize;
        public bool ControlLineSpacing => _controlLineSpacing;
        public TextAnimationValue StartValue => _startValue;
        public TextAnimationValue EndValue => _endValue;
    }
}