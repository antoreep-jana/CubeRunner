using UnityEngine;

public class SettingsPageController : MonoBehaviour
{
    [SerializeField] private GameObject mainSettingsPage;
    [SerializeField] private GameObject devSettingsPage;

    public void OpenDevSettings()
    {
         devSettingsPage.SetActive(true);
        mainSettingsPage.SetActive(false);
    }

    public void CloseDevSettings()
    {
         devSettingsPage.SetActive(false);
        mainSettingsPage.SetActive(true);
    }
}
