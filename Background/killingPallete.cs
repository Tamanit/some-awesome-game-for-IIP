using UnityEngine;

public class killingPallete : MonoBehaviour
{
    public float deadZone;
    void FixedUpdate()
    {
        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
