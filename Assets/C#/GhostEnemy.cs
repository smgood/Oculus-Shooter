using UnityEngine;
using System.Collections;

public class GhostEnemy : MonoBehaviour {
	private enum DirectionChoice { North, East, South, West };
	
	private float speed = 5f;
	
	// Update is called once per frame
	void Update () {
		// Just set the velocity to a constant in the forward direction
		this.rigidbody.velocity =  transform.forward * speed;
	}
	
	// Sets the direction the character is facing
	void SetRotation(DirectionChoice direction) {
		Debug.Log("Chose direction: " + direction);
		// If facing "North", really facing West and so on
			// Key: N = -z = back, E = -x = left, S = front = +z, W = right = +x
		switch(direction) {
			case DirectionChoice.North:
				this.transform.forward = Vector3.back;
				break;
			case DirectionChoice.East:
				this.transform.forward = Vector3.left;
				break;
			case DirectionChoice.South:
				this.transform.forward = Vector3.forward;
				break;
			case DirectionChoice.West:
				this.transform.forward = Vector3.right;
				break;
		}
	}
	
	public void SetPosition(Vector3 newPos) {
	//	Vector3 finalPos = new Vector3(Offset.x + newPos.x, Offset.y + newPos.y, Offset.z + newPos.z);
		this.transform.position = newPos;
	}
	
	public void ChooseDirection(int totalTrue, bool northAvail, bool eastAvail, bool southAvail, bool westAvail) {
		DirectionChoice directionChoice = DirectionChoice.North;
		Debug.Log("Total True: " + totalTrue);
		
		// If only two paths at the node and entering it, only one path out if can't go backwards
		if(totalTrue == 2) {
			// Note: "Forward" is local right. "North" is -Z/"backward"
			if(northAvail && transform.forward != Vector3.back) {
				directionChoice = DirectionChoice.North;
			}
			else if(eastAvail && transform.forward != Vector3.left) {
				directionChoice = DirectionChoice.East;
			}
			else if(southAvail && transform.forward != Vector3.forward) {
				directionChoice = DirectionChoice.South;
			}
			else
				directionChoice = DirectionChoice.West;
		}
		
		// If > 2, time to use a random number
		int choice = Random.Range (1, totalTrue);
		if(totalTrue == 4) {
			// random number == direction choice
			switch(choice) {
				case 1:
					directionChoice = DirectionChoice.North;
					break;
				case 2:
					directionChoice = DirectionChoice.East;
					break;
				case 3:
					directionChoice = DirectionChoice.South;
					break;
				case 4:
					directionChoice = DirectionChoice.West;
					break;
			}
		}
		else if (totalTrue == 3) {
			if(!northAvail){
				switch(choice) {
					case 1:
						directionChoice = DirectionChoice.West;
						break;
					case 2:
						directionChoice = DirectionChoice.East;
						break;
					case 3:
						directionChoice = DirectionChoice.South;
						break;
				}
			}
			else if(!eastAvail)  {
				switch(choice) {
				case 1:
					directionChoice = DirectionChoice.North;
					break;
				case 2:
					directionChoice = DirectionChoice.West;
					break;
				case 3:
					directionChoice = DirectionChoice.South;
					break;
				}
			}
			else if(!southAvail) {
				switch(choice) {
				case 1:
					directionChoice = DirectionChoice.North;
					break;
				case 2:
					directionChoice = DirectionChoice.East;
					break;
				case 3:
					directionChoice = DirectionChoice.West;
					break;
				}
			}
			else
				switch(choice) {
					case 1:
						directionChoice = DirectionChoice.North;
						break;
					case 2:
						directionChoice = DirectionChoice.East;
						break;
					case 3:
						directionChoice = DirectionChoice.South;
						break;
			}
		}
		
		// Now finally turn the character as appropriate
		SetRotation(directionChoice);
	}
}
