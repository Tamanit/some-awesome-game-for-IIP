using UnityEngine;

public class MovingBetweenWagons : MonoBehaviour
{
    private Camera _camera;

    private void Awake() => _camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "LeftDoor":
                MoveToTheNextWagon(-1);
                break;
            case "RightDoor":
                MoveToTheNextWagon(1);
                break;
        }
    }

    private void MoveToTheNextWagon(int i)
    {
        _camera.transform.position += new Vector3(140, 0, 0) * i;
        gameObject.transform.position += new Vector3(48, 0, 0) * i;
    }
}
