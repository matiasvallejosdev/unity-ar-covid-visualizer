using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace UnityEditor.XR.ARFoundation
{
    [CustomEditor(typeof(AROcclusionManager))]
    class AROcclusionManagerEditor : Editor
    {
        SerializedProperty m_EnvironmentDepthMode;
        SerializedProperty m_OcclusionPreferenceMode;
        SerializedProperty m_HumanSegmentationStencilMode;
        SerializedProperty m_HumanSegmentationDepthMode;

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            bool isEnvDepthEnabled = ((EnvironmentDepthMode)m_EnvironmentDepthMode.enumValueIndex).Enabled();
            bool isHumanSegmentationStencilEnabled = ((HumanSegmentationStencilMode)m_HumanSegmentationStencilMode.enumValueIndex).Enabled();
            bool isHumanSegmentationDepthEnabled = ((HumanSegmentationDepthMode)m_HumanSegmentationDepthMode.enumValueIndex).Enabled();
            bool isHumanDepthEnabled = isHumanSegmentationStencilEnabled && isHumanSegmentationDepthEnabled;

            EditorGUILayout.LabelField("Environment Depth", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope(1))
            {
                EditorGUILayout.PropertyField(m_EnvironmentDepthMode);

                if (!isEnvDepthEnabled && !isHumanDepthEnabled)
                {
                    EditorGUILayout.HelpBox("Automatic occlusion during runtime rendering will be disabled with "
                                            + $"{m_EnvironmentDepthMode.displayName} set to "
                                            + $"{m_EnvironmentDepthMode.enumDisplayNames[m_EnvironmentDepthMode.enumValueIndex]}.",
                                            MessageType.Warning);
                }
            }

            EditorGUILayout.LabelField("Human Segmentation", EditorStyles.boldLabel);
            using (new EditorGUI.IndentLevelScope(1))
            {
                EditorGUILayout.PropertyField(m_HumanSegmentationStencilMode);
                if (!isEnvDepthEnabled && !isHumanSegmentationStencilEnabled)
                {
                    using (new EditorGUI.IndentLevelScope(1))
                    {
                        EditorGUILayout.HelpBox("Automatic occlusion during runtime rendering will be disabled with "
                                                + $"{m_HumanSegmentationStencilMode.displayName} set to "
                                                + $"{m_HumanSegmentationStencilMode.enumDisplayNames[m_HumanSegmentationStencilMode.enumValueIndex]}.",
                            MessageType.Warning);
                    }
                }

                EditorGUILayout.PropertyField(m_HumanSegmentationDepthMode);
                if (!isEnvDepthEnabled && !isHumanSegmentationDepthEnabled)
                {
                    using (new EditorGUI.IndentLevelScope(1))
                    {
                        EditorGUILayout.HelpBox("Automatic occlusion during runtime rendering will be disabled with "
                                                + $"{m_HumanSegmentationDepthMode.displayName} set to "
                                                + $"{m_HumanSegmentationDepthMode.enumDisplayNames[m_HumanSegmentationDepthMode.enumValueIndex]}.",
                            MessageType.Warning);
                    }
                }
            }

            EditorGUILayout.PropertyField(m_OcclusionPreferenceMode);

            serializedObject.ApplyModifiedProperties();
        }

        void OnEnable()
        {
            m_EnvironmentDepthMode = serializedObject.FindProperty("m_EnvironmentDepthMode");
            m_HumanSegmentationStencilMode = serializedObject.FindProperty("m_HumanSegmentationStencilMode");
            m_HumanSegmentationDepthMode = serializedObject.FindProperty("m_HumanSegmentationDepthMode");
            m_OcclusionPreferenceMode = serializedObject.FindProperty("m_OcclusionPreferenceMode");
        }
    }
}
