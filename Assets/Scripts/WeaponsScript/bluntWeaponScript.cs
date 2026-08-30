using UnityEngine;

public class bluntWeaponScript : MonoBehaviour
{

    [Header("Player Collectable Prefabs")]
    [Space(10)]
    public GameObject breakableCollectablePrefab; // Reference to the collectable prefab


    [Header("Audio Sources")]
    [Space(10)]
    public AudioSource collectableSound; // Reference to the AudioSource component for collision sound



    [Header("Script References")]
    [Space(10)]
    public Score scoreScript;
    public LevelObjectives levelObjectivesScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log($"Hammer's coordinates are {transform.position.x}, {transform.position.y}, {transform.position.z}");

    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Collectables")
        {
            Debug.Log("Weapon has collided with a collectable object.");
            // Handle collision with other objects (e.g., power-ups, collectibles, etc.)

            collectableSound.Play(); // Play the collision sound effect when collecting a collectable

            scoreScript.AddScore(1); // Add 1 to the score when collecting a collectable

            levelObjectivesScript.incrementDestroyCount();

            Instantiate(
                    breakableCollectablePrefab,
                    new Vector3(
                        other.transform.position.x,
                        other.transform.position.y + 0.2f,
                        other.transform.position.z
                    ),
                    other.transform.rotation
                    );


            Destroy(other.gameObject); // Example: Destroy the collectable object


        }
    }


}
