using UnityEngine.Timeline;
using UnityEngine.UI;

namespace FlexUI
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(SliderAnimationClip))]
    [TrackBindingType(typeof(Slider))]
    public class SliderAnimationTrack
        : AnimationTrack<Slider, SliderAnimationMixer, SliderAnimationMixerBehaviour, SliderAnimationBehaviour>
    {
    }
}