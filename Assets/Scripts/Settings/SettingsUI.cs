using UnityEngine;
using TMPro;

public class SettingsUI : MonoBehaviour
{
    public TMP_Text volumeText;
    public TMP_InputField speedInputField;
    public void SetVolume(float volume)
    {
        Debug.Log("Volume set to: " + volume);
        volumeText.text = Mathf.RoundToInt(volume).ToString();
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
        }
        else
        {
            Debug.LogWarning("Invalid speed value: " + speedText);
        }
    }

}
