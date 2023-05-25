using System.Collections.Generic;
using UnityEngine;

public class SpavnBGPallete : MonoBehaviour
{
    public GameObject desert;
    public GameObject forest;
    public GameObject mountins;
    public GameObject voidDG;

    public float timeToLive = 7f;
    public int minCount = 3;

    private float _timer = 8f;
    private List<GameObject> AllBGs;
    private int BGcounter = 0;
    private GameObject currentBG;

    void Start()
    {
        AllBGs = new List<GameObject>()
        {
            desert,
            forest,
            mountins,
        };
        currentBG = AllBGs[0];
    }
    
    void FixedUpdate()
    {
        if (_timer < timeToLive)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            _timer = 0;
            BGcounter++;
            CreatePalette();
        }
    }

    private void CreatePalette() => Instantiate(ChangeBackground(), transform.position, transform.rotation);

    private GameObject ChangeBackground()
    {
        if (BGcounter == minCount)
        {
            return voidDG;
        }

        if (BGcounter > minCount)
        {
            currentBG = AllBGs[new System.Random().Next(AllBGs.Count)];
            BGcounter = 0;
        }

        return currentBG;
    }

}
