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
    public GameObject endPos;

    public void Start()
    {
        endPos = GameObject.Find("EndPoint");
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
            yield return new WaitForFixedUpdate();
        }
    }
}
