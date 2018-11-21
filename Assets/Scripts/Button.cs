using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public Material mat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Trigger other)
    {
        if (other.tag == "Player")
        {
            getComponent<MeshRenderer>().material = mat;
        }

    }
}
