using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation
{
    [TrackColor(0.1098f, 0.3529f, 0.8392f)]
    [TrackClipType(typeof(GraphicAnimationClip))]
    [TrackBindingType(typeof(Graphic))]
    public class GraphicAnimationTrack
        : AnimationTrack<Graphic, GraphicAnimationMixer, GraphicAnimationMixerBehaviour, GraphicAnimationBehaviour>
    {
    }
}