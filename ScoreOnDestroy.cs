using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnDestroy : MonoBehaviour
{
    private Text text;
    public int score = 15;

    private void Awake()
    {
        text = gameObject.GetComponent<Text>();
        text.text = score.ToString();
    }

    public void AddToScore(int amountToAdd)
    {
        score -= amountToAdd;
        text.text = score.ToString();
    }
          
}
