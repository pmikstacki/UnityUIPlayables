﻿using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.CanvasGroupAnimation
{
    public class CanvasGroupAlphaMixer
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

        public void ApplyFrame(CanvasGroup binding)
        {
            if (_totalWeight == 0)
            {
                return;
            }

            _blendedValue += binding.alpha * (1f - _totalWeight);
            binding.alpha = _blendedValue;
        }
    }
}