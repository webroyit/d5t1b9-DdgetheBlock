using UnityEngine;

public class Block : MonoBehaviour
{
    void Start()
    {
        // Access Rigidbody2D gravity scale property on Unity
        // Time.timeSinceLevelLoad to update the gravity of the block for certain time for this level
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

    // Update is called once per frame
    void Update()
    {
        // Remove the Block if it under the player
        if(transform.position.y < -2f)
        {
            // Remove the Block
            Destroy(gameObject);
        }
    }
}
