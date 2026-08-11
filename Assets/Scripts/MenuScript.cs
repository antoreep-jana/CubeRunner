using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // Load the main game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1 - Pedestrial Walk");
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }

}
