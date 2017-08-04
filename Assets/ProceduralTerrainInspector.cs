#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ProceduralBonzaiTerrain))]
public class ProceduralTerrainInspector : Editor
{
     public override void OnInspectorGUI () {
        DrawDefaultInspector();

        ProceduralBonzaiTerrain myScript = (ProceduralBonzaiTerrain)target;
        if (GUILayout.Button("Your ButtonText"))
        {
            myScript.GenerateHeights();
        }
    }
 }
#endif