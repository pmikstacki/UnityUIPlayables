using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(TextAnimationClip))]
    [TrackBindingType(typeof(Text))]
    public class TextAnimationTrack
        : AnimationTrack<Text, TextAnimationMixer, TextAnimationMixerBehaviour, TextAnimationBehaviour>
    {
    }
}