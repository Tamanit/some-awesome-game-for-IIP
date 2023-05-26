using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDude : MonoBehaviour
{

    public Sprite[] dudes;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = UnityEngine.Random.Range(0, dudes.Length - 1);
        GetComponent<SpriteRenderer>().sprite = dudes[index];
        float moveSpeed = 60f;
    }




    void Update()
    {
    //    child.transform.SetParent(parent,true);
    }
}
