using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        // StartCoroutine to work with IEnumerator
        StartCoroutine(RestartLevel());
    }

    // Deplay on restarting the game
    IEnumerator RestartLevel()
    {
        // Wait 1 second
        yield return new WaitForSeconds(1f);

         // Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
