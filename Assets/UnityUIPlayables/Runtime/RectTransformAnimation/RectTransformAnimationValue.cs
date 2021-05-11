using System;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RectTransformAnimation
{
    [Serializable]
    public class RectTransformAnimationValue
    {
        [SerializeField] private Vector3 _anchoredPosition;

        [SerializeField] private Vector2 _sizeDelta;

        [SerializeField] private Vector3 _localRotation;

        [SerializeField] private Vector3 _localScale;

        public Vector3 AnchoredPosition => _anchoredPosition;

        public Vector2 SizeDelta => _sizeDelta;

        public Vector3 LocalRotation => _localRotation;

        public Vector3 LocalScale => _localScale;
    }
}