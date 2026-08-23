using UnityEngine;
using TMPro;
using UnityEngine.UI; // For Sliders

public class SettingsUI : MonoBehaviour
{
    public TMP_Text volumeText;
    public TMP_InputField speedInputField;
    public Slider volumeSlider;

    private float speed;
    private float volume;


    public void Start()
    {
        if (SettingsSaveManager.HasSave() == false)
        {
            speed = 4.5f;
            volume = 50f;
            SettingsData settingsData = new SettingsData(speed, volume);
            SettingsSaveManager.Save(settingsData);         

            Debug.Log("The Game Initialized the Settings Data File in the Settings Menu Page.");

        }
        else
        {
            LoadSettingsData();
        }
    }


    public void SetVolume(float volume)
    {
        Debug.Log("Volume set to: " + volume);
        volumeText.text = Mathf.RoundToInt(volume).ToString();

        // Adjust & Update the slider
        volumeSlider.value = Mathf.RoundToInt(volume);
    }

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

    private float GetVolume()
    {
        float volume;
        float.TryParse(volumeText.text, out volume);
        return volume;
    }

    public void SaveSettingsData()
    {

        
        // SettingsData settingsData = new SettingsData(speed, volume);
        SettingsData settingsData = new SettingsData(GetSpeed(), GetVolume());
        
        SettingsSaveManager.Save(settingsData);

    }

    public void LoadSettingsData()
    {
        SettingsData data = SettingsSaveManager.Load();

        if (data == null)
        {
            Debug.LogWarning("Save data could not be loaded");
            return;
        }

        speed = data.playerSpeed;

        volume = data.Volume;

        // transform.position = new Vector3( data.posX, data.posY, data.posZ);
        SetVolume(volume);
        Debug.Log("Volume Settings Loaded");

        SetSpeed(speed.ToString());
        Debug.Log("Speed Settings Loaded");


    }


}
