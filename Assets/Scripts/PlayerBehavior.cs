using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Mobile input
    public bool mobileW;
    public bool mobileA;
    public bool mobileS;
    public bool mobileD;
    public bool mobileJump;

    public Rigidbody playerRigidbody;
    public Animator animator;

    [Header("Movement Parameters")]
    [Space(10)]
    public float jumpForce = 15f;
    public float moveSpeed = 5f;
    public float minZ;
    public float maxZ;
    public float rotationSpeed = 360f;

    [Header("SoundsFx")]
    [Space(5)]
    public AudioSource runningSound;

    void Start()
    {
        // runningSound.loop = true;
    }

    // Saving and Loading Player data

    public void SavePlayerData()
    {
        PlayerData playerData = new PlayerData(
            level: 1, // Example level
            score: 100, // Example score
            health: 100f, // Example health
            posX: transform.position.x,
            posY: transform.position.y,
            posZ: transform.position.z
        );

        PlayerSaveManager.Save(playerData);
    }

    public void SetWallCollision(bool value)
    {
        // Handle wall collision logic here
        // For example, you can enable or disable player movement based on the value of 'value'
        // You can also trigger animations or other effects when the player collides with a wall
        Debug.Log("Inside SetWallCollision method. Value: " + value);
        Debug.Log("Player has collided with a wall obstacle! WallCrashed: " + value);
        animator.SetBool("WallCrashed", value);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, minZ, maxZ));

        bool isMoving =
            Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            mobileW || mobileA || mobileS || mobileD;

    bool isJumping = Input.GetKey(KeyCode.Space) || mobileJump;

        if (isMoving)
        {
            animator.SetBool("IsRunning", true);

            if (!runningSound.isPlaying)
            {
                runningSound.Play();
            }
        }
        else
        {
            animator.SetBool("IsRunning", false);

            if (runningSound.isPlaying)
            {
                runningSound.Stop();
            }
        }

        if (isJumping)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }

        // JUMP
        if (Input.GetKey(KeyCode.Space) || mobileJump)
        {
            // playerRigidbody.AddForce(0, jumpForce, 0 );
            transform.Translate(0, jumpForce * Time.deltaTime, 0, Space.World);
        }

        // Adding Four more directions
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) || mobileW && mobileD)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, 135, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 135, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) || mobileW && mobileA)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, 45, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 45, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) || mobileS && mobileD)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, -135, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -135, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) || mobileS && mobileA)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, -45, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -45, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        // GO RIGHT
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || mobileD)
        {
            // transform.Translate(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime);
            // transform.Translate(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime, Space.World);
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, 180, 0);  
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 180, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        // GO LEFT
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || mobileA)
        {
            // transform.Translate(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime, Space.World);
            transform.Translate(0, 0, moveSpeed * Time.deltaTime, Space.World);
            // transform.rotation = Quaternion.Euler(0, 0, 0);  
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        // GO UP
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || mobileW)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);
            // transform.rotation = Quaternion.Euler(0, 90, 0);  
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 90, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        // Go DOWN
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || mobileS)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);
            // transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -90, 0), rotationSpeed * Time.deltaTime);
            // animator.SetBool("IsRunning", true);
            // runningSound.Play();
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

    }
}
