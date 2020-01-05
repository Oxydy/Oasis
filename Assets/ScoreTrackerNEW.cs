using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTrackerNEW : MonoBehaviour {

	static Text scoreText;
	static Text messageText;
	static int currentScore = 0;
	static string currentMessage = "Let's Play";
	public int ScoreToWin;




	public Animator GameOverAnim;

	// Use this for initialization
	void Start ()
	{

		currentMessage = "Let's Play";
		currentScore = 0;
		scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
		messageText  = GameObject.FindGameObjectWithTag("MessageText").GetComponent<Text>();
		UpdateScore(currentScore);
		UpdateMessage(currentMessage);




	}

	public static void UpdateScore(int addedValue)
	{
		currentScore += addedValue;
		scoreText.text = "" + currentScore;

	}

	public static void UpdateMessage(string message)
	{
		currentMessage = message;
		messageText.text = currentMessage;
	}

	// Update is called once per frame
	void Update () 
	{
		if (currentScore == ScoreToWin)
		{


			GameOverAnim.SetTrigger ("Gameover");




		}
	}


}

