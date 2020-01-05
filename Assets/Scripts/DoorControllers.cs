using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DoorControllers : MonoBehaviour {
	
	void Update () {
		Scene scene = SceneManager.GetActiveScene();

		if (scene.name == "minigame4") {
			if (PlayerController.count >= 1) {  //grabs the count variable from the PlayerController script
				Destroy (GameObject.FindWithTag ("Door 1")); //destroys the doors for Level 3
			}
			if (PlayerController.count > 4) {
				Destroy (GameObject.FindWithTag ("Door 2"));
			}
			if (PlayerController.count > 10) {
				Destroy (GameObject.FindWithTag ("Door 3"));
			}
			if (PlayerController.count > 11) {
				Destroy (GameObject.FindWithTag ("Door 4"));
			}
			if (PlayerController.count > 12) {
				Destroy (GameObject.FindWithTag ("Door 5"));
			}
			if (PlayerController.count > 13) {
				Destroy (GameObject.FindWithTag ("Door 6"));
			}
			if (PlayerController.count > 14) {
				Destroy (GameObject.FindWithTag ("Door 7"));
			}
			if (PlayerController.count > 18) {
				Destroy (GameObject.FindWithTag ("Door 8"));
			}
			if (PlayerController.count > 19) {
				Destroy (GameObject.FindWithTag ("Door 9"));
			}
			if (PlayerController.count > 20) {
				Destroy (GameObject.FindWithTag ("Door 10"));
			}
			if (PlayerController.count > 21) {
				Destroy (GameObject.FindWithTag ("Door 11"));
			}
			if (PlayerController.count > 22) {
				Destroy (GameObject.FindWithTag ("Door 12"));
			}
			if (PlayerController.count > 23) {
				Destroy (GameObject.FindWithTag ("Door 13"));
			}
			if (PlayerController.count > 26) {
				Destroy (GameObject.FindWithTag ("Door 14"));
			}
			if (PlayerController.count > 30) {
				Destroy (GameObject.FindWithTag ("Door 15"));
			}
			if (PlayerController.count > 35) {
				Destroy (GameObject.FindWithTag ("Door 16"));
			}
			if (PlayerController.count > 38) {
				Destroy (GameObject.FindWithTag ("Door 17"));
			}
		}
	}
}
