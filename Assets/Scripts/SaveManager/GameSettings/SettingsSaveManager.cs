using UnityEngine;
using System.IO;

public static class SettingsSaveManager
{

    private static string savePath = Path.Combine(Application.persistentDataPath, "SettingsData.json");

    public static void Save(SettingsData settingsData)
    {
         string json = JsonUtility.ToJson(settingsData, true); // Convert the PlayerData object to JSON format with pretty print
        File.WriteAllText(savePath, json);
        Debug.Log("Settings data saved to: " + savePath);
    }

    public static SettingsData Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SettingsData settingsData = JsonUtility.FromJson<SettingsData>(json);
            Debug.Log("Settings data loaded from: " + savePath);
            return settingsData;
        }
        else
        {
            Debug.LogWarning("No save file found at: " + savePath);
            return null; // Return null if no save file exists
        }
    }

      public static bool HasSave()
    {
        return File.Exists(savePath);
    }

}
