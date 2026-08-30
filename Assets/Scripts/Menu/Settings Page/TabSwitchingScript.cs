using UnityEngine;
using System.Collections.Generic;
public class TabSwitchingScript : MonoBehaviour
{

    // public GameObject VolumeSettings;
    // public GameObject GraphicsSettings;

    [SerializeField] private List<GameObject> tabScreens;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // VolumeSettings.SetActive(true);
         SetTabScreenActive(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTabScreenActive(int tabIndex)
    {
        //  A generic version of tab Screens

        for (int i = 0; i < tabScreens.Count ; i++)
        {
            tabScreens[i].SetActive(i == tabIndex);
        }

        
    }

    // public void SetVolumeActive()
    // {
    //     GraphicsSettings.SetActive(false);
    //     VolumeSettings.SetActive(true);
    // }

    // public void SetGraphicsActive()
    // {
    //     GraphicsSettings.SetActive(true);
    //     VolumeSettings.SetActive(false);
    // }


}
