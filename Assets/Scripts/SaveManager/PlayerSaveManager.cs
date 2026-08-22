using UnityEngine;
using System.IO;     // For file operations
public static class PlayerSaveManager // static class to ensure only one instance exists rather than each scene creating a new instance
{
   
    private static string savePath = Path.Combine(Application.persistentDataPath, "playerData.json");

    public static void Save(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData, true); // Convert the PlayerData object to JSON format with pretty print
        File.WriteAllText(savePath, json);
        Debug.Log("Player data saved to: " + savePath);
    }

    public static PlayerData Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Player data loaded from: " + savePath);
            return playerData;
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
