using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwomp : MonoBehaviour
{
    public GameObject player;
    private List<Vector3> positions = new List<Vector3>();
    Transform[] places;
    Vector3 nextPos;
    Vector3 startPos;
    float distance;
    int nextLocation = 0;
    public float speed = 5;
    public GameObject endPos;

    public void Start()
    {
        endPos = gameObject.transform.GetChild(1).gameObject;
        nextPos = endPos.transform.position;
    }

    public void MoveDown()
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
                if (Vector3.Distance(transform.position, player.transform.position) < 0.85)
                {
                    Destroy(player.gameObject);
                }
            }

            yield return new WaitForFixedUpdate();
        }
    }
}
