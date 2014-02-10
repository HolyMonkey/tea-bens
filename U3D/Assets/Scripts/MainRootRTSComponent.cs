using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public sealed class MainRootRTSComponent : MonoBehaviour {

	[SerializeField]
	private List<string> tags;
	private List<string> Tags{
		get{
			if(tags == null)
				tags = new List<string>();
			return tags;
		}
	}

	/*Unity Call*/
	void Start()
	{

	}

	/*API*/
	public bool TagContains(string tag)
	{
		return Tags.Contains(tag);
	}

	public void AddTag(string tag)
	{
		if(!Tags.Contains(tag))
		{
			Tags.Add(tag);
		}
	}

	public void RemoveTag(string tag)
	{
		Tags.Remove(tag);
	}

	public string[] GetAllTag()
	{
		return Tags.ToArray();
	}

	public string s_GetAllTag()
	{
		string ret = "";
		Tags.ForEach(delegate (string s){
			ret += s + ",";
	    });
		return ret;
	}


}
