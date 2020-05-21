using UnityEngine;

public class Block : MonoBehaviour
{
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
