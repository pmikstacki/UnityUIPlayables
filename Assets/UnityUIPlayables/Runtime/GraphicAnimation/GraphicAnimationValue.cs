using System;
using UnityEngine;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation
{
    [Serializable]
    public class GraphicAnimationValue
    {
        [SerializeField] private Color _color = Color.white;

        public Color Color => _color;
    }
}