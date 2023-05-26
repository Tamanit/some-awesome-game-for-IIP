using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{

    public int score;

    // Use this for initialization
    void Start()
    {

        score = 0;

    }


    public void AddToScore(int amountToAdd)
    { score = score + amountToAdd; }
          
}
