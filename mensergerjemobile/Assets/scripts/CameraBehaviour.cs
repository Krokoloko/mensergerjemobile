using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

    /// <summary>
    /// This script manages the zoom and rotation of the camera
    /// </summary>

    public InputManager inputManager;
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private float _zoomSpeed = 0.25f;

    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    void Update()
    {
        // Debug
        if (Input.GetKey("left"))
        {
            float rotationMagX = 0f;
            float rotationMagY = 5f;
            transform.Rotate(rotationMagX, rotationMagY, 0f);
        }
        if (Input.GetKey("right"))
        {
            float rotationMagX = 0f;
            float rotationMagY = -5f;
            transform.Rotate(rotationMagX, rotationMagY, 0f);
        }
        if (Input.GetKey("up"))
        {
            float rotationMagX = -5f;
            float rotationMagY = 0f;
            transform.Rotate(rotationMagX, rotationMagY, 0f);
        }
        if (Input.GetKey("down"))
        {
            float rotationMagX = 5f;
            float rotationMagY = 0f;
            transform.Rotate(rotationMagX, rotationMagY, 0f);
        }
        // End of Debug


        if (inputManager.TwoFingers())
        {
            ZoomCamera();
        }

		if (inputManager.ThreeFingers())
        {
            RotateCamera();
        }
	}

    void ZoomCamera()
    {
        // Touches are stored into local variables for easier access
        Touch zero = inputManager.touchZero;
        Touch one = inputManager.touchOne;
        // Touch positions are stored in Vector2's to compare with the touch locations of the next frame
        Vector2 posZeroPrev = zero.position - zero.deltaPosition;
        Vector2 posOnePrev = one.position - one.deltaPosition;
        // Distances (magnitudes) between Touch locations are stored in floats
        float deltaMagPrev = (posZeroPrev - posOnePrev).magnitude;
        float deltaMagCurr = (zero.position - one.position).magnitude;
        // Difference in distances between 2 frames
        float deltaMagDiff = deltaMagPrev - deltaMagCurr;

        // zooms the camera in or out depending on the delta magnitude difference
        _camera.fieldOfView += deltaMagDiff * _zoomSpeed;
        // limits the zoom to a minimum and maximum distance
        _camera.fieldOfView = Mathf.Clamp(_camera.fieldOfView, 50f, 130f);

    }
    void RotateCamera()
    {
        // Touches are stored into local variables for easier access
        Touch zero = inputManager.touchZero;
        Touch one = inputManager.touchOne;
        Touch two = inputManager.touchTwo;
        // Normalized x and y positions of the Touches
        float touchAvgXPrev = (zero.position.x + one.position.x + two.position.x) / 3;
        float touchAvgYPrev = (zero.position.y + one.position.y + two.position.y) / 3;
        // Magnitude of the previous and current normalized touch position
        float rotationMagX = (touchAvgXPrev - (zero.position.x + one.position.x + two.position.x) / 3);
        float rotationMagY = (touchAvgYPrev - (zero.position.y + one.position.y + two.position.y) / 3);

        transform.Rotate(rotationMagX, rotationMagY, 0f);
    }
}
