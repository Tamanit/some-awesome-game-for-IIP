using System;
using UnityEngine;

public class reactionOnTouchingWater : MonoBehaviour
{
    private Sprite[] _timerSprites;

    private int _waterPunchCounter = 0;
    public int _TTKwater = 6;

    public SpriteRenderer _timerSpriteRender;
    public string tagPlayer;
    public ScoreOnDestroy score;

    private void Awake()
    {
        score = GameObject.Find("Score").GetComponent<ScoreOnDestroy>();
        _timerSprites = Resources.LoadAll<Sprite>("Events/Pipes/timer");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag(tagPlayer)) return;

        if (Input.GetKeyDown(KeyCode.E))
            _timerSpriteRender.sprite = _timerSprites[_waterPunchCounter++];

        if (_waterPunchCounter >= _TTKwater)
        {
            Destroy(gameObject);
            {
                {
                    score.AddToScore(1);
                    Destroy(gameObject);
                }
            }
        }
    }
}

