using UnityEngine;
using System.Collections;

public class Adventure : MonoBehaviour {

	// piece of memory that remembers our location
	string currentRoom = "Lobby";

	bool hasStudentID = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// "Buffer" is a staging are to prepare data
		string textBuffer = "You are currently in:" + currentRoom;

		if (currentRoom == "Lobby") {

			textBuffer += "\nYou see the NYU Poly security guard.";

			textBuffer += "\nPress 'w' to go to elevators.";
			textBuffer += "\nPress 's' to go outside.";
			textBuffer += "\nPress 'd' to do some shit I guess.";
			textBuffer += "\nPress 'a' to learn how to rate this game";

			//detect input
			if ( Input.GetKeyDown (KeyCode.W) ) {

				currentRoom = "Elevators";

			}

			if ( Input.GetKeyDown (KeyCode.S) ) {

				currentRoom = "Outside";

			}

			if ( Input.GetKeyDown (KeyCode.D) ) {
				
				currentRoom = "Somewhere";
				
			}

			if ( Input.GetKeyDown (KeyCode.A) ) {
				
				currentRoom = "Spike T.V. Headquarters";
				
			}
		}

		else if (currentRoom == "Elevators"){

			textBuffer += "\nYou're waiting. They're all broken.";

			if (hasStudentID == false){

				textBuffer += "\nYou can't go in without your ID.";
			}
			else {

				textBuffer += "\nYou swipe ID and the guard smiles.";
			}
		}

		else if (currentRoom == "Outside"){
			
			textBuffer += "\nNothing is here either, this game is really boring.";

		}

		else if (currentRoom == "Somewhere"){
			
			textBuffer += "\nYou did some shit and you feel fulfilled. GOTY?";
			
		}

		else if (currentRoom == "Spike T.V. Headquarters"){
			
			textBuffer += "\nSmash head on wall now for day one DLC!";
			
		}

		//render out text buffer to display on screen

		GetComponent<TextMesh>().text = textBuffer;
	}
}
