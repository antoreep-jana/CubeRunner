using UnityEngine;

public class MobileViewControllerBtn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public FollowPlayher followPlayerScript;

    public GameObject fpsImage;
    public GameObject thirdPersonImage;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onButtonClicked()
    {
        followPlayerScript.ToggleView();
        updateButtonImages();
    }

    void updateButtonImages()
    {
        bool isFPS = followPlayerScript.IsFPS();

        fpsImage.SetActive(isFPS);
        thirdPersonImage.SetActive(!isFPS);

    }
}
