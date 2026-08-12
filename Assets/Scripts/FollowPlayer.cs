using UnityEngine;

public class FollowPlayher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform playerTransform;
    public float offsetX = 5f;
    public float offsetY = 0f;
    public float offsetZ = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = transform.position;

        cameraPosition.x = playerTransform.position.x - offsetX;

        // copying y and z positions and adding those as well

        // cameraPosition.y = playerTransform.position.y;

        // cameraPosition.y = transform.position.y - offsetY;
        cameraPosition.z = playerTransform.position.z - offsetZ;

        transform.position = cameraPosition;
    }
}
