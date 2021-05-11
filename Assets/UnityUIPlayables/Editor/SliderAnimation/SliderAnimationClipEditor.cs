using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.SliderAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.SliderAnimation
{
    [CustomTimelineEditor(typeof(SliderAnimationClip))]
    public class SliderAnimationClipEditor : AnimationTimelineClipEditor<SliderAnimationBehaviour>
    {
    }
}