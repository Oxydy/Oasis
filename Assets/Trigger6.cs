using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger6 : MonoBehaviour
{
	
	public GameObject Cpopup;
	public GameObject Rpopup;


    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other3)
    {
        
		if (other3.tag == "C")
		{
			Destroy(other3.gameObject);
			Debug.Log("Scored the correct answer");     //Displaying "Correct Ball" in Console.
			Cpopup.SetActive(true);
		}
		else if (other3.tag == "B")
		{
			Destroy(other3.gameObject);
			Debug.Log("Scored the wrong answer");     
			Rpopup.SetActive(true);
		}
		else if (other3.tag == "A")
		{
			Destroy(other3.gameObject);
			Debug.Log("Scored the wrong answer");     
			Rpopup.SetActive(true);
		}
}
}