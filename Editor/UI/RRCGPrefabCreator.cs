using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class RRCGPrefabCreator
{
    [MenuItem("RRCG/Create RRCG Prefab")]
    static void CreatePrefab()
    {
        Object prefab = Resources.Load("RRCG");

        GameObject instance = (GameObject) PrefabUtility.InstantiatePrefab(prefab);

        foreach (Transform child in instance.transform)
        {
            child.gameObject.hideFlags = HideFlags.HideInHierarchy;
        }

        Selection.activeObject = instance;
    }
}

