using UnityEngine;


[System.Serializable]
public class DeveloperSettings
{
    public float playerSpeed;
}

[System.Serializable]
public class AudioSettings
{
    public float volume;

    // public float musicVolume;
    // public float sfxVolume;
}


//  TO IMPLEMENT LATER


// public class PlayerSettings
// {
//     public float sensitivity;
//     public float invertYAxis;
// }


// public class GraphicsSettings
// {
//     public float qualityLevel;
//     public float resolution;
//     public float fullscreen;
// }


// public float ControlSettings
//     {
//         public float jumpKey;
//         public float crouchKey;
//     }



[System.Serializable]
public class SettingsData
{
    // public float playerSpeed;

    // public float Volume;

    // public SettingsData(float playerSpeed, float Volume)
    // {
    //     this.playerSpeed = playerSpeed;
    //     this.Volume = Volume;
    // }


    public DeveloperSettings developer;
    public AudioSettings audio;

    public SettingsData()
    {
        developer = new DeveloperSettings();

        audio = new AudioSettings();
    }
}
