using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ColliderTocher : MonoBehaviour
{
    public GameObject train;

    public float TTKFire = 3;
    public int TTKwater = 6;
    private int waterPunchCounter = 0;
    
    
    private float _timer = 0;
    
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject collisionObject = other.gameObject;

        switch (collisionObject.tag)
        {
            case "LeftDoor":
                train.transform.position -= new Vector3(140, 0, 0);
                this.gameObject.transform.position -= new Vector3(48, 0, 0);
                print("трогаю левую дверь");
                break;
            case "RightDoor":
                train.transform.position += new Vector3(140, 0, 0);
                this.gameObject.transform.position += new Vector3(48, 0, 0);
                print("трогаю правую дверь");
                break;
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        GameObject collisionObject = other.gameObject;

        if (collisionObject.CompareTag("water"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                waterPunchCounter++;
                print($"punch:{waterPunchCounter}");
            }
            if (waterPunchCounter >= TTKwater)
            {
                Destroy(collisionObject);
                waterPunchCounter = 0;
            }
        }
        
        
        
        
        switch (collisionObject.tag)
        {
            case "water":
                if (Input.GetKeyDown(KeyCode.E))
                {
                    waterPunchCounter++;
                    print($"punch:{waterPunchCounter}");
                }
                if (waterPunchCounter >= TTKwater)
                {
                    Destroy(collisionObject);
                    waterPunchCounter = 0;
                }
                    
                    break;
            case "fire":
                break;
        }
    }
}
