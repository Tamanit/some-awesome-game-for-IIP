using UnityEngine;

public class SpavnBGPallete : MonoBehaviour
{
    public GameObject backGroundPallet;
    public float timeToLive = 10f;

    private float _timer = 0;
    void Start() => CreatePalette();
    
    void FixedUpdate()
    {
        if (_timer < timeToLive)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            _timer = 0;
            CreatePalette();
        }
    }

    private void CreatePalette() => Instantiate(backGroundPallet, transform.position, transform.rotation);
}
