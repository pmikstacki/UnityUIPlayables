using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.CanvasGroupAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.CanvasGroupAnimation
{
    [CustomTimelineEditor(typeof(CanvasGroupAnimationClip))]
    public class CanvasGroupAnimationClipEditor : AnimationTimelineClipEditor<CanvasGroupAnimationBehaviour>
    {
    }
}