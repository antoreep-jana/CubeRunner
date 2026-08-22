using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance; //  

    public bool continueGame = false;

    private void Awake()
{
    Debug.Log("GameManager Awake() called");

    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        Debug.Log("GameManager Instance assigned: " + Instance);
    }
    else
    {
        Debug.Log("Duplicate GameManager found. Destroying this one.");
        Destroy(gameObject);
    }
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
