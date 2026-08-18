using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, 
IPointerDownHandler, IDragHandler, IPointerUpHandler
{


    public PlayerBehavior playerBehavior;

    [SerializeField] public RectTransform CircleButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    // GEneralizing the variables instead of hard coding the values
    private float OUTER_CIRCLE_SIZE; //= 350f;
    private float HANDLE_SIZE;// = 170f;

    // Prevents tiny joystick movements from triggering movement.
    private const float THRESHOLD = 0.2f; // THRESHOLDING THE BUTTON's MOVEMENT

    // The handle's center can move 90 pixels from the center.
    private float MAX_DISTANCE;//=
        // (OUTER_CIRCLE_SIZE - HANDLE_SIZE) / 2f;

    // 90 pixels

    public Vector2 Input { get; private set;}

    private RectTransform joystickRect;

    private void Awake()
    {
        joystickRect = GetComponent<RectTransform>();
    }

    
    void Start()
    {
        OUTER_CIRCLE_SIZE =  joystickRect.rect.width;
        HANDLE_SIZE = CircleButton.rect.width;
        MAX_DISTANCE = (OUTER_CIRCLE_SIZE - HANDLE_SIZE) / 2f;

        playerBehavior.moveSpeed = 3f; // Set the moveSpeed to 5f
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Return Circle Button to the center.
        CircleButton.anchoredPosition = Vector2.zero;

        Input = Vector2.zero;

        // Reset player movement.
        SetMobileButtons(false, false, false, false);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickRect, eventData.position, eventData.pressEventCamera, out localPoint);

        Debug.Log("Local Point: " + localPoint);

        // Clamp the local point to the maximum distance.
        Vector2 clampedPoint = Vector2.ClampMagnitude(localPoint, MAX_DISTANCE);

        // Move the Circle Button to the clamped position.
        CircleButton.anchoredPosition = clampedPoint;       

        Input = clampedPoint / MAX_DISTANCE;


        // Update player movement.
        UpdateMovement();
        
    }

       private void UpdateMovement()
    {
        bool mobileW = Input.y > THRESHOLD;
        bool mobileA = Input.x < -THRESHOLD;
        bool mobileS = Input.y < -THRESHOLD;
        bool mobileD = Input.x > THRESHOLD;

        SetMobileButtons(
            mobileW,
            mobileA,
            mobileS,
            mobileD
        );
    }

    private void SetMobileButtons(
        bool w,
        bool a,
        bool s,
        bool d)
    {
        playerBehavior.mobileW = w;
        playerBehavior.mobileA = a;
        playerBehavior.mobileS = s;
        playerBehavior.mobileD = d;
    }

}
