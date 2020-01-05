using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOnClick : MonoBehaviour {

	public void OnClick () {
		GameObject.FindWithTag ("Instructions").transform.localScale = new Vector3 (0f, 0f, 0f);
		GameObject.FindWithTag ("Quit").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("How To Play").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("Roll a Ball").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("Play").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("Reset Timer").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("Back").transform.localScale = new Vector3 (0f, 0f, 0f);
	}
}
