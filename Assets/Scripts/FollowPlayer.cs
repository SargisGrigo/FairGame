using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            Vector3 newpos = player.transform.position;
            newpos.y = 0;
            newpos.z = -10;
            transform.position = newpos;
        }
	}
}
