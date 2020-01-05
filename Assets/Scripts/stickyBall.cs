using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyBall : MonoBehaviour
{

    
    public GameObject cameraReference;
    float distanceToCamera = 5;

    float size = 1;

    public GameObject category1;
    bool category1Unlocked = false;

    public GameObject category2;
    bool category2Unlocked = false;

    public GameObject category3;
    bool category3Unlocked = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
       

        unlockPickupCategories();
    }

    void unlockPickupCategories()
    {
        if (category1Unlocked == false)
        {
            if (size >= 1)
            {
                category1Unlocked = true;
                for (int i = 0; i < category1.transform.childCount; i++)
                {
                    category1.transform.GetChild(i).GetComponent<Collider>().isTrigger = true;
                }
            }
        }

        else if (category2Unlocked == false)
        {
            if (size >= 1.1f)
            {
                category2Unlocked = true;
                for (int i = 0; i < category2.transform.childCount; i++)
                {
                    category2.transform.GetChild(i).GetComponent<Collider>().isTrigger = true;
                }
            }
        }

           else if (category3Unlocked == false)
            {
                if (size >= 1.2f)
                {
                    category3Unlocked = true;
                    for (int i = 0; i < category3.transform.childCount; i++)
                    {
                        category3.transform.GetChild(i).GetComponent<Collider>().isTrigger = true;
                    }
                }
            }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Pick Up"))
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            size += 0.01f;
            distanceToCamera += 0.08f;
            other.enabled = false;

            other.transform.SetParent(this.transform);

        }
        else if (other.transform.CompareTag("Timer Power Up"))
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            size += 0.01f;
            distanceToCamera += 0.08f;
            other.enabled = false;

            other.transform.SetParent(this.transform);

        }
		else if (other.transform.CompareTag("food"))
		{
			transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
			size += 0.01f;
			distanceToCamera += 0.08f;
			other.enabled = false;

			other.transform.SetParent(this.transform);

		}
		else if (other.transform.CompareTag("extra"))
		{
			transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
			size += 0.01f;
			distanceToCamera += 0.08f;
			other.enabled = false;

			other.transform.SetParent(this.transform);

		}
    }
}
