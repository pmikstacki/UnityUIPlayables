using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.ImageAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.ImageAnimation
{
    [CustomTimelineEditor(typeof(ImageAnimationClip))]
    public class ImageAnimationClipEditor : AnimationTimelineClipEditor<ImageAnimationBehaviour>
    {
    }
}