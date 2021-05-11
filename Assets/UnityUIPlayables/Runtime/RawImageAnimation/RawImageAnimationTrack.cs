using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RawImageAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(RawImageAnimationClip))]
    [TrackBindingType(typeof(RawImage))]
    public class RawImageAnimationTrack
        : AnimationTrack<RawImage, RawImageAnimationMixer, RawImageAnimationMixerBehaviour, RawImageAnimationBehaviour>
    {
    }
}