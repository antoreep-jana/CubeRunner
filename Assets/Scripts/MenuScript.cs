using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject playBtnPanel;
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

    public void Settings(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("SettingsPage");
    }

    public void BackToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void Continue()
    {
        if (PlayerSaveManager.HasSave())
        {   

            Debug.Log("Found Stored JSON File.");
             GameManager.Instance.continueGame = true;

            //  This needs to be generalized. Which scene to load.
             SceneManager.LoadScene("Level 1 - Pedestrial Walk");
        }
        else
        {
             Debug.Log("No saved game!");
        }
    }

    public void OpenPlayPanel()
    {
        playBtnPanel.SetActive(true);
        
        
    }
    

}
