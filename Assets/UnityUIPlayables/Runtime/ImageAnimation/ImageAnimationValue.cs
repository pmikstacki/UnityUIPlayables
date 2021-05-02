using System;
using UnityEngine;

namespace FlexUI
{
    [Serializable]
    public class ImageAnimationValue : GraphicAnimationValue
    {
        [SerializeField] private float _fillAmount = 1.0f;

        public float FillAmount => _fillAmount;
    }
}