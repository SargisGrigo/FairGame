using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBehaviour : MonoBehaviour {

    GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 1)
            {
                Destroy(gameObject);
                Destroy(player.gameObject);
            }
        }
	}
}
