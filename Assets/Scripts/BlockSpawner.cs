using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // [] for array
    public Transform[] spawnPoints;
    public GameObject blockPrefab;

    void Update()
    {
        SpawnBlocks();
    }

    // Create blocks
    void SpawnBlocks()
    {
        // Get a random number
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for(int i = 0; i < spawnPoints.Length; i++)
        {
            if(randomIndex != i)
            {
                // Create the block
                // Quaternion.identity to prevent rotate
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
            
        }
    }
}
