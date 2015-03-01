using UnityEngine;
using System.Collections;

public class PacmanPortal : MonoBehaviour {

	public Transform mDestination;

	void OnTriggerEnter(Collider other) {
		// Transport the collider to the destination
		other.transform.position = mDestination.position;
	}
}
