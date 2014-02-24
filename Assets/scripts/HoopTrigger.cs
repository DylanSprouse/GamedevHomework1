using UnityEngine;
using System.Collections;

public class HoopTrigger : MonoBehaviour {

	public GameObject camera1, camera2;

	public Transform FedoraTextprefab;

	// Use this for initialization
	void Start () {
	
		camera1.camera.enabled = true;
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel(Application.loadedLevel);
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "pipe" ) {
			Instantiate ( FedoraTextprefab, new Vector3( -85.52047f, 52.61823f, -71.29854f ), Quaternion.Euler(0f,-90f,0f) );
//			Time.timeScale = 0.5f;
			//camera3.enabled = true;
		}
		else if (other.tag == "redball" ){

			camera1.camera.enabled = false;
			camera2.camera.enabled = true;
		
		}


	}
}
