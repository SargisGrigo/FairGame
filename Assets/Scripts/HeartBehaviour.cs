using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBehaviour : MonoBehaviour {

    public enum HeartType {
        Fake,
        Real,
        Spike
    }

    public HeartType type;

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
                switch (type)
                {
                    case HeartType.Fake:
                        Destroy(gameObject);
                        break;
                    case HeartType.Real:
                        Destroy(gameObject);
                        Destroy(player.gameObject);
                        break;
                    case HeartType.Spike:
                        Destroy(player.gameObject);
                        break;
                    default:
                        break;
                }
            }
        }
	}
}
