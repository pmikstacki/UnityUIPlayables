using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR

#endif

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared
{
    internal interface IAttributePropertyDrawer
    {
#if UNITY_EDITOR
        void OnGUI(Rect position, SerializedProperty property, GUIContent label);

        float GetPropertyHeight(SerializedProperty property, GUIContent label);
#endif
    }
}