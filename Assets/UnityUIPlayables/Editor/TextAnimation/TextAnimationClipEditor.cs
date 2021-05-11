using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.TextAnimation
{
    [CustomTimelineEditor(typeof(TextAnimationClip))]
    public class TextAnimationClipEditor : AnimationTimelineClipEditor<TextAnimationBehaviour>
    {
    }
}