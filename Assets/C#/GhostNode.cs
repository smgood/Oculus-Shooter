using UnityEngine;
using System.Collections;

// Used on intersection nodes to tell ghosts which directions available to turn in
public class GhostNode : MonoBehaviour {
	// Note: North == direction ghost gate faces
	private int totalPossibilities = 0;
	public bool NorthAvailable;
	public bool EastAvailable;
	public bool SouthAvailable;
	public bool WestAvailable;
	
	void Start() {
		if(NorthAvailable) totalPossibilities+=1;
		if(EastAvailable) totalPossibilities+=1;
		if(SouthAvailable) totalPossibilities+=1;
		if(WestAvailable) totalPossibilities+=1;
	}
	
	void OnTriggerEnter(Collider other) {
		// If the Collider is an enemy, then move it along
		if(other.tag == "Enemy") {
			Debug.Log("Enemy came into contact with a node!");
			
			//other.GetComponent<GhostEnemy>().SetPosition(this.transform.position);

			other.GetComponent<GhostEnemy>().ChooseDirection(totalPossibilities, NorthAvailable, EastAvailable, SouthAvailable, WestAvailable);
		}
	}
}
