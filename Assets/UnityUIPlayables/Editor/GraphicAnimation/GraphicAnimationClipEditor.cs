using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.Shared;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation;
using UnityEditor.Timeline;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Editor.GraphicAnimation
{
    [CustomTimelineEditor(typeof(GraphicAnimationClip))]
    public class GraphicAnimationClipEditor : AnimationTimelineClipEditor<GraphicAnimationBehaviour>
    {
    }
}