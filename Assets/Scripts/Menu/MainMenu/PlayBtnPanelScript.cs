using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayBtnPanelScript : MonoBehaviour
{
   
    public void NewGame()
    {
        
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("Load Level Page");
    }

    public void LoadGamePlay()
    {
        // SceneManager.LoadScene("GamePlayLoader");
    }

    public void ClosePlayPanel()
    {
        gameObject.SetActive(false);
    }

}
