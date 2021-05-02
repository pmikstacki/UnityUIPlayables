using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(GraphicAnimationClip))]
    public class GraphicAnimationClipEditor : AnimationTimelineClipEditor<GraphicAnimationBehaviour>
    {
    }
}