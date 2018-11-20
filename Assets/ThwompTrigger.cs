using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThwompTrigger : MonoBehaviour
{
    GameObject player;
    GameObject thwomp;
    Thwomp thwompScript;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        thwomp = GameObject.Find("Thwomp");
        thwompScript = thwomp.GetComponent<Thwomp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 1)
        {
            thwompScript.MoveDown();
        }
    }
}
