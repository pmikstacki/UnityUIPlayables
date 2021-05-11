using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine;
using UnityEngine.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.CanvasGroupAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(CanvasGroupAnimationClip))]
    [TrackBindingType(typeof(CanvasGroup))]
    public class CanvasGroupAnimationTrack : AnimationTrack<CanvasGroup, CanvasGroupAnimationMixer,
        CanvasGroupAnimationMixerBehaviour, CanvasGroupAnimationBehaviour>
    {
    }
}