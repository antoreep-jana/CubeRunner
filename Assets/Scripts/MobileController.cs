using UnityEngine;

public class MobileController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(Application.platform == RuntimePlatform.Android);


        // For debugging purposes, you can log the platform to the console.

        // Transform joystickTransform = transform.Find("Joystick");

        // if (joystickTransform != null)
        // {
        //     Joystick joystick = joystickTransform.GetComponent<Joystick>();
        //     if (joystick != null)
        //     {
        //         // You can now access the Joystick component and its properties
        //         Debug.Log("Joystick component found!");
        //     }
        //     else
        //     {
        //         Debug.LogWarning("Joystick component not found on the Joystick GameObject.");
        //     }
        // }
        // else
        // {
        //     Debug.LogWarning("Joystick GameObject not found as a child of MobileController.");
        // }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
