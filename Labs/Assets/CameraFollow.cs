using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;     // The target the camera will follow[cite: 10]
    public float Cameraspeed;    // Speed control for how quickly the camera follows[cite: 10]
    public float minX, maxX;     // The boundaries for the camera's horizontal position[cite: 10]
    public float minY, maxY;     // The boundaries for the camera's vertical position[cite: 10]

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // FixedUpdate is called once per physics frame (Note the capital F and U)
    void FixedUpdate()
    {
        if (target != null)
        {
            // Get the target's position using linear interpolation[cite: 12]
            Vector2 newCamPosition = Vector2.Lerp(transform.position, target.position, Time.deltaTime * Cameraspeed);
            
            // Clamp the camera position within the boundaries[cite: 15]
            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);

            // Set the camera's position, keeping Z at -10f[cite: 15]
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    }
}