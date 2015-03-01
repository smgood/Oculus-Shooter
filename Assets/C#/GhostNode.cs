using UnityEngine;
using System.Collections;

// Used on intersection nodes to tell ghosts which directions available to turn in
public class GhostNode : MonoBehaviour {
	// Note: North == direction ghost gate faces
	public bool NorthAvailable;
	public bool EastAvailable;
	public bool SouthAvailable;
	public bool WestAvailable;
}
