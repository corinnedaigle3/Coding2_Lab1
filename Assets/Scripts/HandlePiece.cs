using UnityEngine;
using UnityEditor;

public class HandlePiece : MonoBehaviour
{
    public string value;
}

[CustomEditor(typeof(HandlePiece))]
public class HandleEditor : Editor
{
    public void OnSceneGUI()
    {
        var t = target as HandlePiece;
        var tr = t.transform;
        var pos = tr.position;

        // display an  red circle around the object
        var color = new Color(1f, 0.2f, 0.1f, 1f);
        Handles.color = color;

        Handles.DrawWireDisc(pos, Vector3.forward, .25f);

        GUI.color = color;
        Handles.Label(pos + Vector3.up * 0.4f, t.value);
    }
}
