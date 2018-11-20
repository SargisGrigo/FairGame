using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackBehaviour : MonoBehaviour {

    bool picked = false;
    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 1.2f)
            {
                picked = true;
            }
        }

        if (picked)
        {
            Vector3 offset = new Vector3(-0.2f , 0, 0);
            player.transform.Translate(new Vector2(0 ,0.2f));
            transform.position = player.transform.position + offset;

            if (transform.position.y > 13)
            {
                Destroy(gameObject);
                Destroy(player.gameObject);
            }
        }
	}
}
