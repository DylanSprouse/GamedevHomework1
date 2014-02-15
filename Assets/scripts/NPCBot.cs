using UnityEngine;
using System.Collections;

public class NPCBot : MonoBehaviour {

	//this variable will hold our reference to the Transform comp. on the player gameOject
	public Transform player;

	public float speed = 5f;

	public float followDistance = 5f;

	public float turnSpeed = 5f; 

	public float bounceHeight = 0.33f;

	public float bounceSpeed = 50f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Follows at a pace that quickens with distance. makes for a good friendly follower behavior. to make it follow at a constant speed, use vector normalization.
//		transform.position += (player.position - transform.position)* Time.deltaTime ; 

		if (Vector3.Distance (transform.position, player.position) > followDistance ){ //makes the npc stop short of the player
			transform.position += Vector3.Normalize(player.position - transform.position)* Time.deltaTime * speed ;
			//travels at constant speed

			if (transform.position.y < 0f) {
				transform.position = new Vector3( transform.position.x, 0f, transform.position.z );
			}
		}


		//make the bot look at the player
//		transform.forward = (player.position - transform.position).normalized ;

		//how the end result is, and makes it gradually turn.
		Vector3 finalFacing = (player.position - transform.position).normalized ;
		transform.forward = Vector3.Lerp (transform.forward, finalFacing, Time.deltaTime * turnSpeed);


		//use the sin wave to make the appearance of bouncing
		transform.position += transform.up * (Mathf.Sin (Time.time * bounceSpeed) * bounceHeight);

	}
}
