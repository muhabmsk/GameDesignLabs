using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private Camera cam; // Reference to the camera component
    public float TargetZoom=3;
    private float ScrollData;
    public float ZoomSpeed=3; // Speed at which the camera zooms in and out
     // Speed at which the camera zooms in and out
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        TargetZoom = cam.orthographicSize; // Initialize TargetZoom with the camera's current orthographic size
    }

    // Update is called once per frame
    void Update()
    {
        ScrollData = Input.GetAxis("Mouse ScrollWheel"); // Get the scroll wheel input
        TargetZoom =    TargetZoom - ScrollData; // Adjust the target zoom based on scroll input
        TargetZoom = Mathf.Clamp(TargetZoom, 3, 6); // Clamp the target zoom between 3 and 6
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, TargetZoom, Time.deltaTime * ZoomSpeed); // Smoothly interpolate the camera's orthographic size towards the target zoom
    }
}
