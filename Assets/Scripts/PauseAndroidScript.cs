using UnityEngine;

public class PauseAndroidScript : MonoBehaviour
{

    public PauseMenuScript pauseMenuScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPauseButtonPressed()
    {
        pauseMenuScript.PauseGame();
    }


}
