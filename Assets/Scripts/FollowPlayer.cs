using UnityEngine;

public class FollowPlayher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform playerTransform;
    public float offset = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = transform.position;

        cameraPosition.x = playerTransform.position.x - offset;

        transform.position = cameraPosition;
    }
}
