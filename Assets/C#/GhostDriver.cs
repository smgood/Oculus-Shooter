using UnityEngine;
using System.Collections;

public class GhostDriver : MonoBehaviour {
	public Transform mStart_Red;
	public Transform mCage_Right_Yellow;
	public Transform mCage_Middle_Blue;
	public Transform mCage_Left_Pink;
	
	public GameObject Red;
	public GameObject Yellow;
	public GameObject Blue;
	public GameObject Pink;

	// Use this for initialization
	void Start () {	
		GameObject red = Instantiate(Red, mStart_Red.position, Quaternion.identity) as GameObject;
		red.transform.parent = this.gameObject.transform;
		red.transform.Rotate(new Vector3(0, 90, 0));
		red.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
