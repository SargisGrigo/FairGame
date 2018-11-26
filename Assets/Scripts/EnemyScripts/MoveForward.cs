using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public Vector2 move;
    Vector2 moveHold;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveHold = new Vector2(transform.position.x + (move.x / 100), transform.position.y + (move.y / 100));
        transform.position = Vector2.Lerp(transform.position, moveHold, 1);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Through")
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject);
            }
            else
            {
                move = new Vector2(move.x * -1, move.y * -1);
            }
            
        }

        
    }
}
