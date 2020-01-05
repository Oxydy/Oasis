using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

    private Rigidbody rigid;

    public bool isFlat = true;
     
	// Use this for initialization
	private void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void Update () {

        Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rigid.AddForce(tilt);
	}
}
