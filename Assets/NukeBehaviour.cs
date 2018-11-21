using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeBehaviour : MonoBehaviour {

    Vector3 startPoint;

	// Use this for initialization
	void Start () {
        startPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 18)
        {
            transform.position = startPoint;
        }
	}
}
