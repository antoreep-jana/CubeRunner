using UnityEngine;
using UnityEngine.SceneManagement; // Required namespace

public class LevelLoader : MonoBehaviour
{

   public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1 - Pedestrial Walk");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
