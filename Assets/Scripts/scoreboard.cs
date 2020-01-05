using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreboard : MonoBehaviour {

	public Text points;
	public Text points2;
	public GameObject rewardScreen;
	public GameObject gameOver;



	// Use this for initialization
	void Start () {
		points.text = "You Current Score: " + PlayerPrefs.GetInt ("Point").ToString();
		points2.text = "You Current Score: " + PlayerPrefs.GetInt ("Point").ToString();


		if (PlayerPrefs.GetInt ("Point") > 200) {
			rewardScreen.SetActive (true);
		}
		else if (PlayerPrefs.GetInt ("Point") < 100) {
			gameOver.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}


	public void redeem()
	{
		Application.OpenURL("https://dwhongwei.wixsite.com/oasis");
	}

	public void menuScreen()
	{
		SceneManager.LoadScene ("Menu");
	}
}
