﻿using UnityEngine;

namespace FlexUI
{
    public class RectTransformScaleMixer
    {
        private Vector3 _blendedValue;
        private float _totalWeight;

        public void SetupFrame()
        {
            _blendedValue = Vector3.zero;
            _totalWeight = 0.0f;
        }

        public void Blend(Vector3 startValue, Vector3 endValue, float inputWeight, float progress)
        {
            _blendedValue += Vector3.Lerp(startValue, endValue, progress) * inputWeight;
            _totalWeight += inputWeight;
        }

        public void ApplyFrame(RectTransform binding)
        {
            if (_totalWeight == 0)
            {
                return;
            }

            _blendedValue += binding.localScale * (1f - _totalWeight);
            binding.localScale = _blendedValue;
        }
    }
}