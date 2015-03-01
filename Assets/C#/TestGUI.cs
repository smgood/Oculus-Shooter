using UnityEngine;
using System.Collections;

public class TestGUI : VRGUI {

	public override void OnVRGUI()
	{
		GUILayout.BeginArea(new Rect(0f, Screen.height/2, Screen.width, Screen.height));
		if (GUILayout.Button("Click Me!"))
		{
			Debug.Log("Clicked on the GUI!!!");
		}
		GUILayout.EndArea();
	}
}
