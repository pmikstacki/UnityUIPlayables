using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.ImageAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(ImageAnimationClip))]
    [TrackBindingType(typeof(Image))]
    public class ImageAnimationTrack
        : AnimationTrack<Image, ImageAnimationMixer, ImageAnimationMixerBehaviour, ImageAnimationBehaviour>
    {
    }
}