using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassMoveOnTrigger : MonoBehaviour {

    GameObject player;
    Transform[] items;
    Transform mTrigger;
    bool picked;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        picked = false;

        mTrigger = GameObject.Find("MassTrigger").transform;
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
            mTrigger.Translate(new Vector2(0, 0.1f));
        }
	}
}
