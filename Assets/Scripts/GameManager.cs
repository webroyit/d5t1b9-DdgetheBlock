using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;

    public void EndGame()
    {
        // StartCoroutine to work with IEnumerator
        StartCoroutine(RestartLevel());
    }

    // Delay on restarting the game
    IEnumerator RestartLevel()
    {
        // 1 is the normal speed
        // 2 is twice the speed
        // .5 is half the speed
        // 0 is stop
        // -1 is going backward

        // Slow down the movement on the game
        Time.timeScale = 1f / slowness;

        // For preformance
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        // Wait 1 second
        // Time.timeScale can affect this
        yield return new WaitForSeconds(1f/ slowness);

        // Reset the effect of Time.timeScale
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

         // Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
