using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverPanel;

    public Score scoreScript;

    public TMP_Text tap2startText;

    public TMP_Text gameOverScoreText;

    public GameObject score;

    public GameObject health;

    public TMP_Text healthTextLabel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        score.SetActive(false); // Ensure the score is visible at the start
        
        health.SetActive(false); // Ensure the health is not visible at the start
        healthTextLabel.gameObject.SetActive(false); // Ensure the health text label is not visible at the start

        gameOverPanel.SetActive(false); // Ensure the game over panel is hidden at the start
        PauseGame(); // Pause the game at the start
    }

    void Update()
    {
        // You can add any additional logic here if needed
        if (tap2startText != null && tap2startText.gameObject.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) // Example: Press left mouse button to restart the game
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game
        tap2startText.gameObject.SetActive(false); // Hide the "Tap to Start" text
        score.SetActive(true); // Show the score when the game starts
        health.SetActive(true); // Show the health when the game starts
        healthTextLabel.gameObject.SetActive(true); // Show the health text label when the game starts
    }


    public void GameOverScreen()
    {
        gameOverPanel.SetActive(true);
        score.SetActive(false); // Hide the score when the game is over
       
        health.SetActive(false);
        healthTextLabel.gameObject.SetActive(false);

        gameOverScoreText.text =  scoreScript.GetScore().ToString(); // Display the final score
        Time.timeScale = 0f; // Pause the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
