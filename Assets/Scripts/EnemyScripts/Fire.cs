using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    int p;
    public int frequency;
    public GameObject bullet;

    // Use this for initialization
    void Start()
    {
        p = 60 * frequency;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        p--;
        if (p < 1)
        {
            p = 60 * frequency;
            shoot();
        }


    }

    void shoot()
    {
        GameObject shot;
        shot = Instantiate(bullet, transform.position, transform.rotation, transform);
        shot.transform.localScale = bullet.transform.localScale;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

    }
}
