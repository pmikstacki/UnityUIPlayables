using System;
using UnityEngine;

namespace FlexUI
{
    [Serializable]
    public class SliderAnimationValue
    {
        [SerializeField] private float _value;

        public float Value => _value;
    }
}