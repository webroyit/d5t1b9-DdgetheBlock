using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour
{
    // [] for array
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    public int score = 0;
    public int highScore = 0;

    // Drag and drop the UI Text to these input field on Script component in Unity
    public Text scoreText;
    public Text highScoreText;

    void Start()
    {
        // Apply it with the data from local device
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        highScore = PlayerPrefs.GetInt("HighScore");
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

            if(score > highScore){
                // Save the high score on local device
                PlayerPrefs.SetInt("HighScore", score);

                highScore = score;
            }
            
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
