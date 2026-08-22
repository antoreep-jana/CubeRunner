using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject gameObject;

    public PlayerBehavior playerBehaviorScript;

    private bool isPaused = false;
    void Start()
    {
        
    }

    public void SaveGame()
    {
        playerBehaviorScript.SavePlayerData();
    }

    // Update is called once per frame
       void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        // Pause the game by stopping time
        Time.timeScale = 0f;
        // Show the pause menu UI
        gameObject.SetActive(true);

        isPaused = true;
    }



    public void ResumeGame()
    {
        // Resume the game by unpausing time
        Time.timeScale = 1f;
        // Hide the pause menu UI
        gameObject.SetActive(false);

        isPaused = false;
    }

    public void MainMenu()
    {
        // Load the main menu scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }


}
