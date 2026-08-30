using UnityEngine;
using UnityEngine.SceneManagement; // Required namespace
using System.Collections.Generic;

// For Image and text
using UnityEngine.UI;
using TMPro;

public class LevelLoader : MonoBehaviour
{   

    [SerializeField] List<GameObject> GameLevels;
    void Start()
    {
        PlayerData playerData = PlayerSaveManager.Load();

        for (int i = 0; i < playerData.maxLevel; i++)
        {
            // GameLevels[i].SetActive(true);
            // SetTabAlpha(tabS)
            SetTabAlpha(GameLevels[i], 255);
            RemoveLockIcon(GameLevels[i]);
            MakeButtonClickable(GameLevels[i]);
        }

        for (int i = playerData.maxLevel; i < GameLevels.Count; i++)
        {
            SetTabAlpha(GameLevels[i], 40);
        }
    }

    private void RemoveLockIcon(GameObject gameLevel)
    {
        Transform lockIcon = gameLevel.transform.Find("Locked Icon");//.GetComponent<Image>();
        lockIcon.gameObject.SetActive(false);
    }

    private void MakeButtonClickable(GameObject gameLevel)
    {
        Button gameBtn = gameLevel.transform.Find("Button").GetComponent<Button>();

        // Make it interactable = true
        gameBtn.interactable = true;
    }


   private void SetTabAlpha(GameObject tab, byte alpha)
    {
        // Background Img
        Image background = tab.transform.Find("BackgroundImg").GetComponent<Image>();
        SetImageAlpha(background, alpha);

        Debug.Log("New alpha value -> " + background.color.a);
        // Text
        TMP_Text levelName = tab.transform.Find("LevelName").GetComponent<TMP_Text>();
        SetTextAlpha(levelName, alpha);
        // Button
        Image btnImg = tab.transform.Find("Button").GetComponent<Image>();
        SetImageAlpha(btnImg, alpha);

        


    }

    private void SetImageAlpha(Image image, byte alpha)
    {
        Color color = image.color;

        Debug.Log("Current Alpha Value -> " + color.a);
        color.a = alpha / 255f;
        image.color = color;
    }

    private void SetTextAlpha(TMP_Text text, byte alpha)
    {
        Color color = text.color;
        color.a = alpha/255f;
        text.color = color;
    }
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
