using UnityEngine;
using System.Collections;

public class CheatCombo : MonoBehaviour {

	int counter = 0;
	
	public int lineLength = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		int Secretnum = Random.Range (0 ,2);
		
		if ( Secretnum == 0 ) {
			GetComponent<TextMesh>().text += "/" ;
			
		}
		else {
			GetComponent<TextMesh>().text += "\\" ;
		}
		
		counter = counter +1;
		if (counter > 20) {
			GetComponent<TextMesh>().text += "\n" ;
			counter = 0;
		}
		
	}
}
