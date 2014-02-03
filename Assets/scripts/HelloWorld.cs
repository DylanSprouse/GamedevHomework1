using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// public makes a variable global, otherwise it defaults to private
	public string message = "Hallo mein Freunde";

	// Use this for initialization
	void Start () {
		Debug.Log ( "Hello World!" );

		//Fur der Vatterlandeschaft (displays "hello world" in german in our 3d text
		GetComponent<TextMesh>().text = message;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
