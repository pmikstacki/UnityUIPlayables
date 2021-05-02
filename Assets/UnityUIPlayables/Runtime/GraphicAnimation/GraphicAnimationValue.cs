using System;
using UnityEngine;

namespace FlexUI
{
    [Serializable]
    public class GraphicAnimationValue
    {
        [SerializeField] private Color _color = Color.white;

        public Color Color => _color;
    }
}