﻿using UnityEngine;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextAnimation
{
    public class TextLineSpacingMixer
    {
        private float _blendedValue;
        private float _totalWeight;

        public void SetupFrame()
        {
            _blendedValue = 0.0f;
            _totalWeight = 0.0f;
        }

        public void Blend(float startValue, float endValue, float inputWeight, float progress)
        {
            _blendedValue += Mathf.Lerp(startValue, endValue, progress) * inputWeight;
            _totalWeight += inputWeight;
        }

        public void ApplyFrame(Text binding)
        {
            if (_totalWeight == 0)
            {
                return;
            }

            _blendedValue += binding.lineSpacing * (1f - _totalWeight);
            binding.lineSpacing = _blendedValue;
        }
    }
}