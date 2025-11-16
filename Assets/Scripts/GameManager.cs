using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject winGamePanel;
    private int brickCount;

    void Start()
    {
        brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    public void BrickDestroyed()
    {
        brickCount--;

        if (brickCount <= 0)
        {
            WinGame();
        }
    }
    public void GameOver()
    {
        // Pause the game
        Time.timeScale = 0f;
        
        // Show restart button
        gameOverPanel.SetActive(true);
    }
    
    public void ResetGame()
    {
        // Reset the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // Restart the game
        Time.timeScale = 1f;
    }

    private void WinGame()
    {
        // Pause the game
        Time.timeScale = 0f;
        
        // Show restart button and congratulations message
        winGamePanel.SetActive(true);
    }
}
