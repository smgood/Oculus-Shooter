using UnityEngine;
using System.Collections;

public class texture : MonoBehaviour {
	public Texture2D texthair;

	// Use this for initialization
	void Start () {
		Texture crossHair = renderer.material.mainTexture;
			print("Size is " + crossHair.width + " by " + crossHair.height);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
