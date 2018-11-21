using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathChecker : MonoBehaviour {

    GameObject player;
    public GameObject deathText;

    // Use this for initialization
    void Start () {
        deathText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("Player");
        if (player == null)
        {
            deathText.SetActive(true);
        }

        if(deathText.active && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
