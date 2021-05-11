using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.TextMeshProUGUIAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.TextMeshProUGUIAnimation
{
    [CustomTimelineEditor(typeof(TextMeshProUGUIAnimationClip))]
    public class TextMeshProUGUIAnimationClipEditor : AnimationTimelineClipEditor<TextMeshProUGUIAnimationBehaviour>
    {
    }
}