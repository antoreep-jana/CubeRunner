using UnityEngine;

public class MobileController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(Application.platform == RuntimePlatform.Android);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
