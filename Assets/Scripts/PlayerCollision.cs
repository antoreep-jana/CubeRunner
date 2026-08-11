using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public PlayerBehavior playerScript;

    public GameOver gameOverScript;

    public Score scoreScript;

    public AudioSource collectableSound; // Reference to the AudioSource component for collision sound

    public AudioSource collisionSound; // Reference to the AudioSource component for collision sound
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
    //     if (other.gameObject.tag == "Collidables")
    //     {
    //         Debug.Log("Player has collided with an obstacle!");
    //         // Handle collision with obstacle (e.g., reduce health, play sound, etc.)
    //         // Destroy(other.gameObject); // Example: Destroy the obstacle
    //     }
    //     else if (other.gameObject.tag == "Collectables")
    //     {
    //         Debug.Log("Player has collided with a collectable object.");
    //         // Handle collision with other objects (e.g., power-ups, collectibles, etc.)
    //         Destroy(other.gameObject); // Example: Destroy the collectable object
    //     }

        if (other.gameObject.CompareTag("Collidables"))
        {
            // Debug.Log("Player has collided with an obstacle!");
            // Handle collision with obstacle (e.g., reduce health, play sound, etc.)
            // Destroy(other.gameObject); // Example: Destroy the obstacle
            
            //  More sophisticated collision handling can be done here, such as reducing player health, playing a sound effect, or triggering an animation.
            // playerScript.HandleCollisionWithObstacle();

            Debug.Log("Player has collided with an obstacle! Game Over!");
           
            collisionSound.Play(); // Play the collision sound effect
            gameOverScript.GameOverScreen(); // Call the GameOverScreen method to display the game over panel
             playerScript.enabled = false; // Disable the PlayerScript to stop player movement
        }
        else if (other.gameObject.CompareTag("Wall Collidables"))
        {
            Debug.Log("Player has collided with a wall obstacle!");
            // Handle collision with wall obstacle (e.g., reduce health, play sound, etc.)
            // Destroy(other.gameObject); // Example: Destroy the wall obstacle
            
            Debug.Log("Player has collided with a wall obstacle! Game Over!");

            playerScript.SetWallCollision(true); // Call the method to handle wall collision
            collisionSound.Play(); // Play the collision sound effect
            gameOverScript.GameOverScreen(); // Call the GameOverScreen method to display the game over panel
             playerScript.enabled = false; // Disable the PlayerScript to stop player movement
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Collectables")
        {
            Debug.Log("Player has collided with a collectable object.");
            // Handle collision with other objects (e.g., power-ups, collectibles, etc.)

            collectableSound.Play(); // Play the collision sound effect when collecting a collectable

            scoreScript.AddScore(1); // Add 1 to the score when collecting a collectable


            Destroy(other.gameObject); // Example: Destroy the collectable object
        }
    }

    



}
