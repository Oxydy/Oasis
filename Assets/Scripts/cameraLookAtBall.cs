using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookAtBall : MonoBehaviour {

    public GameObject ball;
    Vector3 lookAtOffset;

    // Use this for initialization
    void Start()
    {
        lookAtOffset = new Vector3(0, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ball.transform.position + lookAtOffset);
    }
}
