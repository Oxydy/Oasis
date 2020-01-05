using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour {

	public Transform target;
	public Vector3 offsetToTarget = new Vector3( 0.0f, 1.5f, 0.0f );
	private Transform myTransform;

	void  Start (){
		myTransform = transform;
	}

	void  Update (){
		myTransform.position = target.position + offsetToTarget;
	}
}
