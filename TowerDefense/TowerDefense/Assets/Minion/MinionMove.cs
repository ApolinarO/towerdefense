// Apolinar Ortega
// Used to move the enemy to the destination
using UnityEngine;
using System.Collections;

public class MinionMove : MonoBehaviour 
{
	void Start () {}
	
	void Update () {}

	//get it to move linear-like (no acceleration)
	//Set where total velocity = 
	//Create method getUnitVectorOf(int magnitude) that returns a vector of the magnitude and direction
	public void Move(Vector3 destination, float  moveSpeed)
	{
		Vector3 distance = destination - gameObject.transform.position;
		Vector3 velocity = new Vector3(distance.x * moveSpeed, distance.y * moveSpeed, distance.z * moveSpeed);
		transform.Translate (velocity);
		//Mover.transform.Translate (Velocity);
	}

	//Rotates object until it looks at the same position velocity is heading
	private void rotateToLookForward(Vector3 velocity)
	{

	}
}