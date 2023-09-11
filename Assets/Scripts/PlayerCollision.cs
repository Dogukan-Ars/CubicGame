
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // A reference to our PlayerMovement script

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable the players movement and also we can write this like "GetComponent<PlayerMovement>().enabled = true;"
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
