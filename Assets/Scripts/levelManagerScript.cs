﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManagerScript : MonoBehaviour {

    public bool settledP1, settledP2, settledP3, settledP4; //declaring bool that tells when each player is on a safe platform


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (settledP1 && settledP2 && settledP3 && settledP4)//if all players are on a safe platform
        {
            //scene change time
            Debug.Log("scene change time!");
        }

	}
}