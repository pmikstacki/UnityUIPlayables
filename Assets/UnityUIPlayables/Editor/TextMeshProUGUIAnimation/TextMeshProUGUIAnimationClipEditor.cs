using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(TextMeshProUGUIAnimationClip))]
    public class TextMeshProUGUIAnimationClipEditor : AnimationTimelineClipEditor<TextMeshProUGUIAnimationBehaviour>
    {
    }
}