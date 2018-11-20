using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKillBlock : MonoBehaviour
{

    public Vector2 movePath;
    Vector2 moveHold;

    bool activate;

    // Use this for initialization
    void Start()
    {
        activate = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activate == true)
        {
            move();
        }
    }


    public void move()
    {
        moveHold = new Vector2(transform.position.x + (movePath.x / 100), transform.position.y + (movePath.y / 100));
        transform.position = Vector2.Lerp(transform.position, moveHold, 1);
    }

    public void triggered()
    {
        activate = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && activate == true)
        {
            //kill player
            collision.gameObject.GetComponent<Player>();
        }
    }

}
