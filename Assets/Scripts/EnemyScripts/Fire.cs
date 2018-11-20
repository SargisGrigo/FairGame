using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    int p;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        p = 60;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        p--;
        if(p < 1)
        {
            p = 60;
            shoot();
        }


	}

    void shoot()
    {

    }

}
