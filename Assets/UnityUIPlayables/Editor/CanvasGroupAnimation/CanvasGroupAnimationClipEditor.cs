using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(CanvasGroupAnimationClip))]
    public class CanvasGroupAnimationClipEditor : AnimationTimelineClipEditor<CanvasGroupAnimationBehaviour>
    {
    }
}