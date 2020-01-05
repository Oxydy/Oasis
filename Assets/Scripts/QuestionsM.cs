using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestionsM : MonoBehaviour {

	public GameObject Qpopup,  Qpopup1,  Qpopup2,  Qpopup3,  Qpopup4,  Qpopup5,  Qpopup6; 
	public GameObject Cpopup, Cpopup1, Cpopup2, Cpopup3, Cpopup4, Cpopup5, Cpopup6;
	public GameObject Rpopup, Rpopup1, Rpopup2, Rpopup3, Rpopup4, Rpopup5, Rpopup6;
	public Text question, question1, question2, question3, question4, question5, question6;
	public Text Answer1, Answer1_1, Answer1_2, Answer1_3, Answer1_4, Answer1_5, Answer1_6;
	public Text Answer2, Answer2_1, Answer2_2, Answer2_3, Answer2_4, Answer2_5, Answer2_6;
	public Text Answer3, Answer3_1, Answer3_2, Answer3_3, Answer3_4, Answer3_5, Answer3_6;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other3)
	{
		
		if (other3.tag == "q1")
		{
			Qpopup.SetActive(true);
			Debug.Log("Q1 detected");     
			question.text = "Energy sources that do not increase carbon emissions include";
			Answer1.text = "Solar Cells";
			Answer2.text = "Wind mills";
			Answer3.text = "Nuclear power plants";
		}
		else if (other3.tag == "q2")
		{
			Qpopup1.SetActive(true);
			Debug.Log("Q2 detected");     
			question1.text = "Cimate represents";
			Answer1_1.text = "Long-term average weather";
			Answer2_1.text = "Weather averaged over a year";
			Answer3_1.text = "It is a measure of variations in the amount of precipitation";
		}
		else if (other3.tag == "q3")
		{
			Qpopup2.SetActive(true);
			Debug.Log("Q3 detected");     
			question2.text = "Cimate represents";
			Answer1_2.text = "Long-term average weather";
			Answer2_2.text = "Weather averaged over a year";
			Answer3_2.text = "It is a measure of variations in the amount of precipitation";
		}
		else if (other3.tag == "q4")
		{
			Qpopup3.SetActive(true);
			Debug.Log("Q4 detected");     
			question3.text = "Cimate represents";
			Answer1_3.text = "Long-term average weather";
			Answer2_3.text = "Weather averaged over a year";
			Answer3_3.text = "It is a measure of variations in the amount of precipitation";
		}
		else if (other3.tag == "q5")
		{
			Qpopup4.SetActive(true);
			Debug.Log("Q5 detected");     
			question4.text = "Cimate represents";
			Answer1_4.text = "Long-term average weather";
			Answer2_4.text = "Weather averaged over a year";
			Answer3_4.text = "It is a measure of variations in the amount of precipitation";
		}
		else if (other3.tag == "q6")
		{
			Qpopup5.SetActive(true);
			Debug.Log("Q6 detected");     
			question5.text = "Cimate represents";
			Answer1_5.text = "Long-term average weather";
			Answer2_5.text = "Weather averaged over a year";
			Answer3_5.text = "It is a measure of variations in the amount of precipitation";
		}
		else if (other3.tag == "q7")
		{
			Qpopup6.SetActive(true);
			Debug.Log("Q7 detected");     
			question6.text = "Cimate represents";
			Answer1_6.text = "Long-term average weather";
			Answer2_6.text = "Weather averaged over a year";
			Answer3_6.text = "It is a measure of variations in the amount of precipitation";
		}
}
	public void closePanel()
	{
		Qpopup.SetActive (false); //close Question Panel
		Qpopup1.SetActive (false);
		Qpopup2.SetActive (false);
		Qpopup3.SetActive (false);
		Qpopup4.SetActive (false);
		Qpopup5.SetActive (false);
		Qpopup6.SetActive (false);
	}
	public void retryPanel()
	{
		Rpopup.SetActive (false); //close Question Panel
		Rpopup1.SetActive (false);
		Rpopup2.SetActive (false);
		Rpopup3.SetActive (false);
		Rpopup4.SetActive (false);
		Rpopup5.SetActive (false);
		Rpopup6.SetActive (false);
	}
}
