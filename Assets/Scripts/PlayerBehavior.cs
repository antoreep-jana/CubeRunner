using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody playerRigidbody;


    public Animator animator;
    public float jumpForce = 5f;
    public float moveSpeed = 5f;
    public float minZ;
    public float maxZ;


    void Start()
    {
        
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


        
       

        // JUMP
        if (Input.GetKey(KeyCode.Space))
        {
            // playerRigidbody.AddForce(0, jumpForce, 0 );
            transform.Translate(0, jumpForce * Time.deltaTime, 0, Space.World);
        }


        // GO RIGHT
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            // transform.Translate(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime);
            transform.Translate(moveSpeed * Time.deltaTime, 0, -moveSpeed * Time.deltaTime, Space.World);
            animator.SetBool("IsRunning", true);
        }
        // GO LEFT
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, moveSpeed * Time.deltaTime, Space.World);
            animator.SetBool("IsRunning", true);
            
        }
         else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);
            animator.SetBool("IsRunning", true);
            
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);
            animator.SetBool("IsRunning", true);
            
        }else{

        animator.SetBool("IsRunning", false);
        }
        // {
        // else
        // {
        //     transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);
        // }


    }
}
