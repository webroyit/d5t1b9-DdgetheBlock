using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;

    // Good for physics stuff because it is run on a fixed timer
    void FixedUpdate()
    {
        // Note: Add Rigidbody 2D component to the player and set the Body Type to kinematic

        // For left and right movement
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
    }
}
