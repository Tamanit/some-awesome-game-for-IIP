using UnityEngine;

public class jumpingColider : MonoBehaviour
{
    private BoxCollider2D collider;
    private bool ItsStatmentIsFalse = true;

    private void Start() => collider = gameObject.GetComponent<BoxCollider2D>();

    void Update()
    {
        var t = new Vector2(1, 0);
        collider.offset = ItsStatmentIsFalse ? collider.offset + t : collider.offset - t;
        ItsStatmentIsFalse = !ItsStatmentIsFalse;
    }
}
