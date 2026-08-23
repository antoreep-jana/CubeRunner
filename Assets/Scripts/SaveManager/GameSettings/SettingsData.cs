using UnityEngine;

[System.Serializable]
public class SettingsData
{
    public float playerSpeed;

    public float Volume;


    public SettingsData(float playerSpeed, float Volume)
    {
        this.playerSpeed = playerSpeed;
        this.Volume = Volume;
    }
}
