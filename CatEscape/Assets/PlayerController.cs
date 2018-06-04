using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void LButtonDown() {
        if(transform.position.x > -8)
        {
            transform.Translate(-2, 0, 0);
        }
        }
    public void RButtonDown()
    {
        if (transform.position.x < 8)
        {
            transform.Translate(2, 0, 0);
        }
	}
}
