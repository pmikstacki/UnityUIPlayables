using UnityEditor.Timeline;

namespace FlexUI.Editor
{
    [CustomTimelineEditor(typeof(SliderAnimationClip))]
    public class SliderAnimationClipEditor : AnimationTimelineClipEditor<SliderAnimationBehaviour>
    {
    }
}