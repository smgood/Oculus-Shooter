using UnityEngine;
using System.Collections;

public class oculusGUI : VRGUI  {
	public GUISkin customSkin;

		public override void OnVRGUI()
		{
			GUILayout.BeginArea(new Rect(0f, 0f, Screen.width/2, Screen.height));
			if (GUILayout.Button("Click Me!"))
			{
					GUI.skin = customSkin;

				Debug.Log("doSomething()");
			}
			GUILayout.EndArea();
	}

}
