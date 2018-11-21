using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwomp : MonoBehaviour
{
    private List<Vector3> positions = new List<Vector3>();
    Transform[] places;
    Vector3 nextPos;
    Vector3 startPos;
    float distance;
    int nextLocation = 0;
    public float speed = 5;
    private GameObject endPos;
    public float objectSize = 1.0f;

    //Only assign this in the inspector if the object is meant to kill the player
    public GameObject player;

    public void Start()
    {
        endPos = gameObject.transform.GetChild(1).gameObject;
        nextPos = endPos.transform.position;
    }

    public void MoveDirection()
    {
        StartCoroutine(Moving());
    }

    IEnumerator Moving()
    {
        while (Vector3.Distance(this.transform.position, endPos.transform.position) > 0.1)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, nextPos, speed);

            if (player != null)
            {
                if (Vector3.Distance(transform.position, player.transform.position) < objectSize)
                {
                    Destroy(player.gameObject);
                }
            }

            yield return new WaitForFixedUpdate();
        }
    }
}