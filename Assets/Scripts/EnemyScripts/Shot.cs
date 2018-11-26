using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public int speed;
    float speedHold;

    // Use this for initialization
    void Start()
    {
        speedHold = speed;
        speedHold /= 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speedHold, transform.position.y, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

    }
}
