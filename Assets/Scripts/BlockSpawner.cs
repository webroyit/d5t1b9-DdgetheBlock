using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // [] for array
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        // Get a random number
        int randomIndex = Random.Range(0, spawnPoints.Length);
    }
}
