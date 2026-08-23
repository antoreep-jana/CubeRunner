using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderBuildDebugger : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler,
    IBeginDragHandler,
    IDragHandler,
    IEndDragHandler
{
    private Slider slider;

    private float lastValue;
    private bool pointerDown;
    private bool dragging;

    private void Awake()
    {
        slider = GetComponent<Slider>();

        Debug.Log("=== SLIDER DEBUGGER AWAKE ===");
        PrintState();
    }

    private void Start()
    {
        Debug.Log("=== SLIDER DEBUGGER START ===");
        PrintState();

        lastValue = slider.value;

        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void Update()
    {
        if (slider == null)
            return;

        if (!Mathf.Approximately(lastValue, slider.value))
        {
            Debug.Log(
                $"[SliderDebugger] VALUE CHANGED: " +
                $"{lastValue} -> {slider.value}"
            );

            lastValue = slider.value;
        }
    }

    private void OnSliderValueChanged(float value)
    {
        Debug.Log(
            $"[SliderDebugger] onValueChanged fired. " +
            $"Value = {value}"
        );
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;

        Debug.Log(
            $"[SliderDebugger] POINTER DOWN on Slider. " +
            $"Position = {eventData.position}"
        );
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;

        Debug.Log(
            $"[SliderDebugger] POINTER UP on Slider. " +
            $"Position = {eventData.position}"
        );
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragging = true;

        Debug.Log(
            $"[SliderDebugger] BEGIN DRAG. " +
            $"Position = {eventData.position}"
        );
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(
            $"[SliderDebugger] DRAGGING. " +
            $"Position = {eventData.position}, " +
            $"Slider Value = {slider.value}"
        );
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;

        Debug.Log(
            $"[SliderDebugger] END DRAG. " +
            $"Final Value = {slider.value}"
        );
    }

    private void PrintState()
    {
        if (slider == null)
        {
            Debug.LogError(
                "[SliderDebugger] No Slider component found!"
            );
            return;
        }

        Debug.Log(
            $"[SliderDebugger] " +
            $"GameObject = {gameObject.name}\n" +
            $"ActiveSelf = {gameObject.activeSelf}\n" +
            $"ActiveInHierarchy = {gameObject.activeInHierarchy}\n" +
            $"Interactable = {slider.interactable}\n" +
            $"Value = {slider.value}\n" +
            $"Min = {slider.minValue}\n" +
            $"Max = {slider.maxValue}\n" +
            $"WholeNumbers = {slider.wholeNumbers}"
        );

        Canvas canvas = GetComponentInParent<Canvas>();

        if (canvas != null)
        {
            Debug.Log(
                $"[SliderDebugger] Canvas = {canvas.name}\n" +
                $"Canvas Active = {canvas.gameObject.activeInHierarchy}\n" +
                $"Render Mode = {canvas.renderMode}"
            );
        }
        else
        {
            Debug.LogWarning(
                "[SliderDebugger] Could not find parent Canvas."
            );
        }

        GraphicRaycaster raycaster =
            GetComponentInParent<GraphicRaycaster>();

        if (raycaster != null)
        {
            Debug.Log(
                $"[SliderDebugger] GraphicRaycaster = {raycaster.name}\n" +
                $"Enabled = {raycaster.enabled}"
            );
        }
        else
        {
            Debug.LogError(
                "[SliderDebugger] NO GRAPHIC RAYCASTER FOUND!"
            );
        }

        EventSystem eventSystem = EventSystem.current;

        if (eventSystem != null)
        {
            Debug.Log(
                $"[SliderDebugger] EventSystem = {eventSystem.name}\n" +
                $"Active = {eventSystem.gameObject.activeInHierarchy}\n" +
                $"CurrentSelected = " +
                $"{eventSystem.currentSelectedGameObject?.name}"
            );
        }
        else
        {
            Debug.LogError(
                "[SliderDebugger] NO CURRENT EVENT SYSTEM!"
            );
        }
    }

    private void OnDestroy()
    {
        if (slider != null)
        {
            slider.onValueChanged.RemoveListener(
                OnSliderValueChanged
            );
        }
    }
}