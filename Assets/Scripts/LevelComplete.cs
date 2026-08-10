using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // public SceneManager SceneManager;

    public GameObject levelCompletePanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");

            levelCompletePanel.SetActive(true); // Show the level complete panel
                Time.timeScale = 0f;

            // SceneManager.LoadNextLevel(); // Load the next level when the player reaches the finish line
            // Handle level completion logic here (e.g., load next level, show UI, etc.)
        }
    }

    public void NextLevel()
    {
        // Logic to load the next level goes here
        // For example, you can use SceneManager.LoadScene() to load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next scene in the build index
    }

    public void MainMenu()
    {
        // Logic to return to the main menu goes here
        // For example, you can use SceneManager.LoadScene() to load the main menu scene

        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with the actual name of your main menu scene
    }




}
