using UnityEngine;
using TMPro;
using UnityEngine.UI; // For Sliders

public class DevSettingsUI : MonoBehaviour
{
    public TMP_InputField speedInputField;
    private float playerSpeed;
    // private float volume;


    public void Start()
    {
        // if (SettingsSaveManager.HasSave() == false)
        // {
        //     // playerSpeed = 4.5f;
        //     // volume = 50f;
        //     // SettingsData settingsData = new SettingsData(playerSpeed, volume);
        //     // SettingsSaveManager.Save(settingsData);         

        //     SettingsData settings = new SettingsData();

        //     settings.developer.playerSpeed = 5f;
        //     settings.audio.volume = 50f;

        //     SettingsSaveManager.Save(settings);

        //     Debug.Log("The Game Initialized the Settings Data File in the Settings Menu Page.");

        // }
        // else
        // {
        //     LoadSettingsData();
        // }

        LoadDevSettingsData();
        
    }


    // public void SetVolume(float value)
    // {   

    //     volume = value;
    //     Debug.Log("Volume set to: " + volume);
    //     volumeText.text = Mathf.RoundToInt(volume).ToString();

    //     // Adjust & Update the slider
    //     // volumeSlider.value = Mathf.RoundToInt(volume);
    //     // volumeSlider.SetValueWithoutNotify(volume);

    // }

    public void SetBrightness(float brightness)
    {
        Debug.Log("Brightness set to: " + brightness);
    }

    public void SetResolution(int resolutionIndex)
    {
        Debug.Log("Resolution set to index: " + resolutionIndex);
    }

    public void SetQuality(int qualityIndex)
    {
        Debug.Log("Quality set to index: " + qualityIndex);
    }

    public void SetSpeed(string speedText)
    {
       if (float.TryParse(speedText, out float speed))
        {
            Debug.Log("Speed set to: " + speed);
            speedInputField.text = speed.ToString();
            
        }
        else
        {
            Debug.LogWarning("Invalid speed value: " + speedText);
        }
    }

    private float GetSpeed()
    {
        float speed;
        float.TryParse(speedInputField.text, out speed);

        return speed;
    }

    // private float GetVolume()
    // {
    //     float volume;
    //     float.TryParse(volumeText.text, out volume);
    //     return volume;
    // }

    public void SaveSettingsData()
    {

        
        // SettingsData settingsData = new SettingsData(speed, volume);
        // SettingsData settingsData = new SettingsData(GetSpeed(), GetVolume());
        
        
        // SettingsData newSettingsData = new SettingsData();
        // newSettingsData.developer.playerSpeed = GetSpeed();
        // newSettingsData.audio.volume = GetVolume();
        
        // SettingsSaveManager.Save(newSettingsData);

        SettingsData settingsData = SettingsSaveManager.Load();
        settingsData.developer.playerSpeed = GetSpeed();
        // newSettingsData.audio.volume = GetVolume();
        
        SettingsSaveManager.Save(settingsData);



    }

    public void LoadDevSettingsData()
    {
        SettingsData data = SettingsSaveManager.Load();

        if (data == null)
        {
            Debug.LogWarning("Save data could not be loaded");
            return;
        }

        // playerSpeed = data.playerSpeed;

        // volume = data.Volume;

        playerSpeed = data.developer.playerSpeed;
        // volume = data.audio.volume;

        // transform.position = new Vector3( data.posX, data.posY, data.posZ);
        // volumeSlider.SetValueWithoutNotify(volume);

        // SetVolume(volume);
        // Debug.Log("Volume Settings Loaded");

        SetSpeed(playerSpeed.ToString());
        Debug.Log("playerSpeed Settings Loaded");


    }


}
