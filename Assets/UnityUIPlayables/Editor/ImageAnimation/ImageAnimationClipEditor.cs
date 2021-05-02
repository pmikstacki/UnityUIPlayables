using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(ImageAnimationClip))]
    public class ImageAnimationClipEditor : AnimationTimelineClipEditor<ImageAnimationBehaviour>
    {
    }
}