using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    public AudioClip jumpSound;

    private AudioSource audioSource;
    private Player player;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (Input.GetButtonDown("Jump"))
        {
            audioSource.PlayOneShot(jumpSound);
            player.OnJumpInputDown();
        }

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
    }
}
