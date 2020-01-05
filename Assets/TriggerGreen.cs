using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerGreen : MonoBehaviour
{

	public GameObject popup;
	public GameObject tryAgain;


    // Use this for initialization
    void Start()
    {
		Scene scene = SceneManager.GetActiveScene ();


    }

    // Update is called once per frame
    void Update()
    {

    }

	void FixedUpdate ()
	{


		//Restarts level by pressing r, loads next levels by pressing n and b
		if (Input.GetKeyDown ("r")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		if (Input.GetKeyDown ("n")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
		if (Input.GetKeyDown ("p")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
		}
	}

    void OnTriggerEnter(Collider other3)
    {
        
        if (other3.tag == "A")
        {
            Destroy(other3.gameObject);
            Debug.Log("Scored the correct answer");     //Displaying "Correct Ball" in Console.
			popup.SetActive(true);
        }
		else if (other3.tag == "B")
		{
			Destroy(other3.gameObject);
			Debug.Log("Scored the wrong answer");     
			tryAgain.SetActive(true);
		}
		else if (other3.tag == "C")
		{
			Destroy(other3.gameObject);
			Debug.Log("Scored the wrong answer");     
			tryAgain.SetActive(true);
    	}
}
	public void DisplayNextScene ()
	{
			StartCoroutine("LoadNextLevel");
		}
	IEnumerator LoadNextLevel() { //Coroutine for loading the next scene after 5 seconds
		float WaitForSeconds;
		yield return new WaitForSeconds (0.1f); 
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void resetlevel()
	{

		Application.LoadLevel (Application .loadedLevel  );

	}
}