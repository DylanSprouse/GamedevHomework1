using UnityEngine;
using System.Collections;

public class CharacterControllerIsGrounded : MonoBehaviour {
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded)
			print("We are grounded");
		
	}
}