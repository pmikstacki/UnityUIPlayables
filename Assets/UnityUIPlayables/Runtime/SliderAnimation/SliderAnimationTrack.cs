using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.SliderAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(SliderAnimationClip))]
    [TrackBindingType(typeof(Slider))]
    public class SliderAnimationTrack
        : AnimationTrack<Slider, SliderAnimationMixer, SliderAnimationMixerBehaviour, SliderAnimationBehaviour>
    {
    }
}