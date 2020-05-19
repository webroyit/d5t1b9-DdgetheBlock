using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5f;

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

        // rb.position is the current position of the player
        Vector2 newPosition = rb.position + Vector2.right * x;

        // Make sure that the player does not move out of range
        // Second argument is the min value
        // Third argument is the max value
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        // Move the player
        rb.MovePosition(newPosition);
    }
}
