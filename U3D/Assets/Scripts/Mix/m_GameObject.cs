using UnityEngine;
using System.Collections;

public static class m_GameObject{

	static public MainRootRTSComponent GetMainRootRTSComponent(this GameObject gameObject)
	{
		MainRootRTSComponent ret_comp = gameObject.GetComponent<MainRootRTSComponent>();
		if(ret_comp == null){
			ret_comp = gameObject.AddComponent<MainRootRTSComponent>();
		}
		return ret_comp;
	}
}
