using UnityEngine;

public class BackgroundSpavner : MonoBehaviour
{
    public float timeToLive = 7.266665f;
    public int minCount = 3;
    public Vector3 spawnPosition = new Vector3(437, 0, 0);

    private Sprite[] _backgrounds;
    private GameObject _backgroundPallete;
    private SpriteRenderer _palleteSpriteRenderer;
    private Sprite _currentSprite;
    
    private float _timer = 8f;
    private int _backgroundPalleteCounter;

    private void Awake()
    {
        _backgroundPallete = Resources.Load<GameObject>("Backgrounds/BackgroundPalette");
        _palleteSpriteRenderer = _backgroundPallete.GetComponent<SpriteRenderer>();

        _backgrounds = new[]
        {
            Resources.Load<Sprite>("Backgrounds/Hills Free (update 3.0)"),
            Resources.Load<Sprite>("Backgrounds/background_glacial_mountains"),
            Resources.Load<Sprite>("Backgrounds/Background")
        };
        _currentSprite = _backgrounds[0];
    }

    void FixedUpdate()
    {
        _timer = _timer < timeToLive ? _timer += Time.fixedDeltaTime : 0;

        if (_timer == 0) ChangeBackground();
    }

    private void ChangeBackground()
    {
        if (++_backgroundPalleteCounter == minCount)
        {
            _currentSprite = null;
        }
        else if (_backgroundPalleteCounter > minCount)
        {
            _currentSprite = _backgrounds[new System.Random().Next(_backgrounds.Length)];
            _backgroundPalleteCounter = 0;
        }

        _palleteSpriteRenderer.sprite = _currentSprite;
        Instantiate(_backgroundPallete, spawnPosition, transform.rotation);
    }
}