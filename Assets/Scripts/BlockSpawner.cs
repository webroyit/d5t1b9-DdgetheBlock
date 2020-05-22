using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour
{
    // [] for array
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    public Text scoreText;

    public int score = 0;

    public Text highScore;

    void Start()
    {
        // Apply it with the data from local device
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    void Update()
    {
        // Unity variable
        // The amount of seconds that has passed by when the game started
        if(Time.time >= timeToSpawn)
        {
            // Call this function
            SpawnBlocks();

            // Update the player score for each block spawn
            score += 1;
            scoreText.text = score.ToString();

            // Save the high score on local device
            PlayerPrefs.SetInt("HighScore", score);

            // Time it takes to spawn a new block
            timeToSpawn = Time.time + timeBetweenWaves;
        }
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
