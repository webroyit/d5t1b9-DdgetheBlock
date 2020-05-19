using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;

    private Rigidbody2D rb;

    void Start()
    {
        // Get access to the Rigidbody2D on unity
        rb = GetComponent<Rigidbody2D>();
    }

    // Good for physics stuff because it is run on a fixed timer
    void FixedUpdate()
    {
        // Note: Add Rigidbody 2D component to the player and set the Body Type to kinematic

        // For left and right movement
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        // Move the player
        // rb.position is the current position of the player
        rb.MovePosition(rb.position + Vector2.right * x);
    }
}
