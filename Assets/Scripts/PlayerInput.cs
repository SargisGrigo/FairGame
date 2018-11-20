﻿using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    public AudioClip jumpSound;

    private AudioSource audioSource;
    private Player player;
    private Animator anime;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GetComponent<Player>();
        anime = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (Input.GetButtonDown("Jump"))
        {
            audioSource.PlayOneShot(jumpSound);
<<<<<<< HEAD
=======
            anime.SetTrigger(jumpHash);
>>>>>>> origin/GAB
            player.OnJumpInputDown();
        }

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
    }
}
