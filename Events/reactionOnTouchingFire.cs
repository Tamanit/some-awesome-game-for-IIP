using UnityEngine;

public class reactionOnTouchingFire : MonoBehaviour
{
    private int _firePunchCounter = 0;
    public int _TTKfire = 1;
    
    public string tagPlayer = "Fireman";

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag(tagPlayer)) return;

        if (Input.GetKey(KeyCode.E))
            _firePunchCounter++;

        if (_firePunchCounter >= _TTKfire)
            Destroy(gameObject);
    }
}

