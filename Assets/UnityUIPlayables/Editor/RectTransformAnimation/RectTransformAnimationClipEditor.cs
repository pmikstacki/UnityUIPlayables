using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RectTransformAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.RectTransformAnimation
{
    [CustomTimelineEditor(typeof(RectTransformAnimationClip))]
    public class RectTransformAnimationClipEditor : AnimationTimelineClipEditor<RectTransformAnimationBehaviour>
    {
    }
}