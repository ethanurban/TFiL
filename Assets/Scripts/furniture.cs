using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furniture : MonoBehaviour {

    public GameObject levelManager; //it can now talk to the level manager

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("P1"))
        {
            levelManager.GetComponent<levelManagerScript>().settledP1 = true;
            Debug.Log("player one is set!");

        }
        if (other.gameObject.CompareTag("P2"))
        {
            levelManager.GetComponent<levelManagerScript>().settledP2 = true;
            Debug.Log("player two is set!");
        }
        if (other.gameObject.CompareTag("P3"))
        {
            levelManager.GetComponent<levelManagerScript>().settledP3 = true;
            Debug.Log("player three is set!");
        }
        if (other.gameObject.CompareTag("P4"))
        {
            levelManager.GetComponent<levelManagerScript>().settledP4 = true;
            Debug.Log("player four is set!");
        }
    }
}
