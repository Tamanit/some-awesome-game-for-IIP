using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera camera;

    public float zoomStep;
    public float maxZoomSize = 121;
    public float minZoomSize = 51;
    public float upToCenterSize;


    void FixedUpdate()
    {
        var playerPosition = gameObject.transform.position;

        camera.transform.position = new Vector3
        (
            playerPosition.x,
            playerPosition.y + upToCenterSize,
            -10

        );

        switch (Input.GetAxis("Mouse ScrollWheel"))
        {

            case (float)0.1:
                camera.fieldOfView += camera.fieldOfView >= maxZoomSize ? 0 : zoomStep;
                break;
            case (float)-0.1:
                camera.fieldOfView -= camera.fieldOfView <= minZoomSize ? 0 : zoomStep;
                break;
        }

    }
}