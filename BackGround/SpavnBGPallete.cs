using UnityEngine;

public class SpavnBGPallete : MonoBehaviour
{
    public GameObject[] backGrounds;
    public GameObject voidDG;

    public float timeToLive = 7f;
    public int minCount = 3;

    private float _timer = 8f;

    private int _bGCounter = 0;

    private void Start()
    {
        currentBG = backGrounds[0];
    }

    void FixedUpdate()
    {
        _timer = _timer < timeToLive ? _timer += Time.fixedDeltaTime : 0;

        if (_timer == 0) ChangeBackground();
    }

    private GameObject currentBG;
    private void ChangeBackground()
    {
        if (++_bGCounter == minCount)
        {
            currentBG = voidDG;
        }
        else if (_bGCounter > minCount)
        {
            currentBG = backGrounds[new System.Random().Next(backGrounds.Length)];
            _bGCounter = 0;
        }
        
        Instantiate(currentBG, transform.position, transform.rotation);
    }
}