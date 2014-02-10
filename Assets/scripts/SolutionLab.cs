using UnityEngine;
using System.Collections;

// this script inherits from Blockly.cs instead of just MonoBehaviour
// so it also has access to all the functions inside Blockly.cs! wow!

// all Blockly *functions* start with the word "Blockly"...
// BlocklyMove(), BlocklyTurn(), BlocklyDetectWall()

public class SolutionLab : Blockly {

	// FixedUpdate is called every X seconds... "X" is defined in Edit >> Project Settings >> Time
	void FixedUpdate () {
		// LAB CHALLENGE: use *ONLY* if() statements and Blockly_ functions
		// within the FEWEST lines of code possible to solve the maze!
		int five = 5;
		
		// move forward
		BlocklyMove( transform.forward );


		// if we detect a wall that is 2 units in front of us, then turn 45 degrees to the left
		if ( BlocklyDetectWall ( transform.forward, 2f ) ) {

			BlocklyTurn (45);

		}

		else if (BlocklyDetectWall (-transform.right, 2f) ) {

			BlocklyMove( transform.forward );

		}
		
		else {

			BlocklyTurn (90f);

			BlocklyMove( transform.forward );



		}


		

	}
}
