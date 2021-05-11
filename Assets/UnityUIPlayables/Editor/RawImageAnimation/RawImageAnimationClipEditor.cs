using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RawImageAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.RawImageAnimation
{
    [CustomTimelineEditor(typeof(RawImageAnimationClip))]
    public class RawImageAnimationClipEditor : AnimationTimelineClipEditor<RawImageAnimationBehaviour>
    {
    }
}