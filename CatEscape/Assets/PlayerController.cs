﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void LButtonDown() {
            transform.Translate(-3, 0, 0);
        }
    public void RButtonDown()
    {
            transform.Translate(3, 0, 0);
	}
}
