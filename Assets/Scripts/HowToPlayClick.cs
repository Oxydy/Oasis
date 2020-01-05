using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.FindWithTag ("Instructions").transform.localScale = new Vector3(0f, 0f, 0f);
		GameObject.FindWithTag ("Back").transform.localScale = new Vector3 (0f, 0f, 0f);
	}
	public void OnClick () {
		GameObject.FindWithTag ("Instructions").transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		GameObject.FindWithTag ("Quit").transform.localScale = new Vector3 (0f, 0f, 0f);
		GameObject.FindWithTag ("How To Play").transform.localScale = new Vector3 (0f, 0f, 0f);
		GameObject.FindWithTag ("Roll a Ball").transform.localScale = new Vector3 (0f, 0f, 0f);
		GameObject.FindWithTag ("Play").transform.localScale = new Vector3 (0f, 0f, 0f);
		GameObject.FindWithTag ("Back").transform.localScale = new Vector3 (1f, 1f, 1f);
		GameObject.FindWithTag ("Reset Timer").transform.localScale = new Vector3 (1f, 0f, 1f);
		GameObject.FindWithTag ("Reset Point").transform.localScale = new Vector3 (1f, 0f, 1f);
	}
}
