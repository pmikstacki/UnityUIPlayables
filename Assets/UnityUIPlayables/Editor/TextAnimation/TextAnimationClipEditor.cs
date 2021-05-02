using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(TextAnimationClip))]
    public class TextAnimationClipEditor : AnimationTimelineClipEditor<TextAnimationBehaviour>
    {
    }
}