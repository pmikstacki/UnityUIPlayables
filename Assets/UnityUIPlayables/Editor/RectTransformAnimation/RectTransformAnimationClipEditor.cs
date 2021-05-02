using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(RectTransformAnimationClip))]
    public class RectTransformAnimationClipEditor : AnimationTimelineClipEditor<RectTransformAnimationBehaviour>
    {
    }
}