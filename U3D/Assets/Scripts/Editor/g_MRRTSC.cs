using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(MainRootRTSComponent))]
public class g_MRRTSC : Editor {

	private string toAddTag;

	public override void OnInspectorGUI() {
		MainRootRTSComponent myTarget = (MainRootRTSComponent) target;

		GUI.color = Color.red;
		EditorGUILayout.LabelField("DONT'T DELE THIS COMPONENT, PLS!!!!");

		GUILayout.BeginHorizontal();
		GUI.color = Color.blue;

		foreach(string _tag in myTarget.GetAllTag())
		{
			if(GUILayout.Button(_tag)) 
			{
				myTarget.RemoveTag(_tag);
			}
		}

		GUI.color = Color.white;
		GUILayout.EndHorizontal();

		GUILayout.Space(5);

		GUILayout.BeginHorizontal();

		toAddTag = EditorGUILayout.TextField(toAddTag);
		if(GUILayout.Button("Add", GUILayout.Width(Screen.width / 3)))
		{
			myTarget.AddTag(toAddTag);
			toAddTag = "";
		}

		GUILayout.EndHorizontal();


	}

}
