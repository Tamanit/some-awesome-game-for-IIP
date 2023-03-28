using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera camera;

    public float zoomStep;

    public float maxZoomSize;

    public float minZoomSIze;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var transformPosition = new Vector3();
        transformPosition.z = -10;
        transformPosition.x = gameObject.transform.position.x;
        transformPosition.y = gameObject.transform.position.y;
        camera.transform.position = transformPosition;
        
        switch (Input.GetAxis("Mouse ScrollWheel"))
        {
            case (float)0.1:
                camera.orthographicSize += camera.orthographicSize == maxZoomSize ? 0: zoomStep;
                break;
            case (float)-0.1:
                camera.orthographicSize -= camera.orthographicSize == minZoomSIze ? 0: zoomStep;
                break;
        }

    }
}
