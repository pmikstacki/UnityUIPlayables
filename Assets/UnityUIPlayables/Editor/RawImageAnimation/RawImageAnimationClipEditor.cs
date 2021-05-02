using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(RawImageAnimationClip))]
    public class RawImageAnimationClipEditor : AnimationTimelineClipEditor<RawImageAnimationBehaviour>
    {
    }
}