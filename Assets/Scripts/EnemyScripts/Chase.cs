using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public int speed;
    float speedHold;

    float moveX, moveY;

    Vector2 move;
    Vector2 moveHold;

    GameObject player;

    // Use this for initialization
    void Start () {
        speedHold = speed;
        speedHold /= 100;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {


            if (player.transform.position.x < transform.position.x)
            {
                moveX = -speedHold;
            }
            else if (player.transform.position.x > transform.position.x)
            {
                moveX = speedHold;
            }
            else
            {
                moveX = 0;
            }

            if (player.transform.position.y < transform.position.y)
            {
                moveY = -speedHold;
            }
            else if (player.transform.position.y > transform.position.y)
            {
                moveY = speedHold;
            }
            else
            {
                moveY = 0;
            }

            moveHold = new Vector2(transform.position.x + move.x, transform.position.y + move.y);
            transform.position = Vector2.Lerp(transform.position, moveHold, 1);

        }
    }
}
