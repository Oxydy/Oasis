using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour 
{

	public void resetlevel()
	{
		
		Application.LoadLevel (Application .loadedLevel  );

	}
}