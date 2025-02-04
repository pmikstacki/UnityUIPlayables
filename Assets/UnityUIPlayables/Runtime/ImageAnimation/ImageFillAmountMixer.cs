﻿using UnityEngine;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.ImageAnimation
{
    public class ImageFillAmountMixer
    {
        private float _blendedValue;
        private float _totalWeight;

        public void SetupFrame()
        {
            _blendedValue = 0;
            _totalWeight = 0.0f;
        }

        public void Blend(float startValue, float endValue, float inputWeight, float progress)
        {
            _blendedValue += Mathf.Lerp(startValue, endValue, progress) * inputWeight;
            _totalWeight += inputWeight;
        }

        public void ApplyFrame(Image binding)
        {
            if (_totalWeight == 0)
            {
                return;
            }

            _blendedValue += binding.fillAmount * (1f - _totalWeight);
            binding.fillAmount = _blendedValue;
        }
    }
}