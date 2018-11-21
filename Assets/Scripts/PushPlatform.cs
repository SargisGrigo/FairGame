using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlatform : MonoBehaviour {

    GameObject player;
	private Vector3 normalizeDirection;

	// set the target location for the object to move to
	public Transform target;
    public float speed = 5f;
	public int distance; 

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
		normalizeDirection = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(Vector3.Distance(player.transform.position, transform.position));
        if(Vector3.Distance(player.transform.position, transform.position) < distance)
        {
			 transform.position += normalizeDirection * speed * Time.deltaTime;
        }
    }
}
