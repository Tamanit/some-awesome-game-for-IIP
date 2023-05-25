using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEvent : MonoBehaviour
{
    public GameObject pipeFail;
    public GameObject fire;
    public GameObject drezin;

    public GameObject train;

    private float timeToLive = 9f;
    private int minCount = 3;
    private float _timer = 0f;
    
    public string[] eventNames = new string[]{"fire","pipe", "drezin"};
    
    void FixedUpdate()
    {
        
        var index = UnityEngine.Random.Range(0, eventNames.Length);
        string eventName = eventNames[index];
        

        if (_timer < timeToLive)
        {
            _timer += Time.deltaTime;
        }
        else
        {           
            _timer = 0;
            switch (eventName)
            {
                case "pipe":
                    CreatePipe();
                    timeToLive = 7f;
                    break;
                case "fire":
                    CreateFire();
                    timeToLive = 8f;
                    break;
                case "drezin":
                    RollDrezin();
                    timeToLive = 9f;
                    break;
            }
        }   
    } 
    private Vector2 CreatePipePosition()
    {
        var wagon = new System.Random().Next(-1, 2);
        var x = UnityEngine.Random.Range(-60.5f, 52.5f) + 140 * wagon;
       var y = -22f;
       var pos = new Vector2(x, y);
       return pos;
    }
    private void CreatePipe() => Instantiate(pipeFail, CreatePipePosition(), transform.rotation);

    private Vector2 CreateFirePosition()
    {
        var wagon = new System.Random().Next(-1, 2);
        var x = UnityEngine.Random.Range(-60.5f, 52.5f)+ 140 * wagon;
        var y = UnityEngine.Random.Range(-20f, 17f);
        var pos = new Vector2(x, y);
        return pos;
    }
    private void CreateFire() => Instantiate(fire, CreateFirePosition(), transform.rotation);
    private void RollDrezin() => Instantiate(drezin, new Vector2(-110,-20), transform.rotation);
   
}
