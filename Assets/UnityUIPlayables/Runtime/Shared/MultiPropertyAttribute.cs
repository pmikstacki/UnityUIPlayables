using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR

#endif

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared
{
    internal abstract class MultiPropertyAttribute : PropertyAttribute
    {
        public MultiPropertyAttribute[] Attributes;
        public IAttributePropertyDrawer[] PropertyDrawers;

#if UNITY_EDITOR
        public virtual void OnPreGUI(Rect position, SerializedProperty property)
        {
        }

        public virtual void OnPostGUI(Rect position, SerializedProperty property, bool changed)
        {
        }

        public virtual bool IsVisible(SerializedProperty property)
        {
            return true;
        }
#endif
    }
}