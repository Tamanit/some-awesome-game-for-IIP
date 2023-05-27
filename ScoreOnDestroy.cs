using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnDestroy : MonoBehaviour
{
    private Text text;
    public int score = 15;
    public int createdEvents;

    public GameObject panel;
    public Text header;
    public Text subText;

    private void Awake()
    {
        text = gameObject.GetComponent<Text>();
        text.text = score.ToString();
    }

    public void AddToScore(int amountToAdd)
    {
        score -= amountToAdd;
        text.text = score.ToString();

        if (score <= 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            header.text = "You Won!!!";
            subText.text =
                "And now you can relax a while. . .\nHowever the new problrms will come in near future.\nSo, be prepared\n\nAnd good luck";

        }
    }

    public void AddToCreatedEvents()
    {
        createdEvents += 1;

        if (createdEvents - score  >= 10)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            header.text = "You Lose((((";
            subText.text =
                "Don`t be sad. . .\nSometime we can fail.\nAnd that's okay, take a break\n\nAnd try again later";

        }
    }
          
}
