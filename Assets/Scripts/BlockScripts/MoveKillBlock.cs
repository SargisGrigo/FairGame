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
    void Update()
    {



        if (activate == true)
        {
            move();
        }
    }


    public void move()
    {
        moveHold = new Vector2(transform.position.x + movePath.x, transform.position.y + movePath.y);
        transform.position = Vector2.Lerp(transform.position, moveHold, 0.5f);
    }

    public void triggered()
    {
        activate = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //kill player
            //collision.gameObject.GetComponent<>();
        }
    }

}
