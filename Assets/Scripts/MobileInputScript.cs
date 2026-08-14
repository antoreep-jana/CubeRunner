using UnityEngine;
using UnityEngine.EventSystems;

public class MobileInputScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public PlayerBehavior playerBehavior;

    public string button;


    public void OnPointerDown(PointerEventData eventData)
    {
        // Handle button press
        if (button == "W")
        {
            playerBehavior.mobileW = true;
        }
        else if (button == "A")
        {
            playerBehavior.mobileA = true;
        }
        else if (button == "S")
        {
            playerBehavior.mobileS = true;
        }
        else if (button == "D")
        {
            playerBehavior.mobileD = true;
        }
        else if (button == "Jump")
        {
            playerBehavior.mobileJump = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Handle button release
        if (button == "W")
        {
            playerBehavior.mobileW = false;
        }
        else if (button == "A")
        {
            playerBehavior.mobileA = false;
        }
        else if (button == "S")
        {
            playerBehavior.mobileS = false;
        }
        else if (button == "D")
        {
            playerBehavior.mobileD = false;
        }
        else if (button == "Jump")
        {
            playerBehavior.mobileJump = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
