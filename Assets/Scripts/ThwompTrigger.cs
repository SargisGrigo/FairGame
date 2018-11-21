using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThwompTrigger : MonoBehaviour
{
    GameObject player;
    Thwomp thwomp;
    Thwomp thwompScript;
    AudioSource audio;
    public AudioClip audioClip;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
        player = GameObject.Find("Player");
        thwomp = gameObject.transform.GetComponentInParent<Thwomp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 0.7f)
            {
                thwomp.MoveDown();
                audio.PlayOneShot(audioClip);
            }
        }
    }
}
