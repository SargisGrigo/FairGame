using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkArea : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other.tag);
            if (GetComponentInParent<MoveKillBlock>())
            {
                GetComponentInParent<MoveKillBlock>().triggered();
            }



        }
    }
}
