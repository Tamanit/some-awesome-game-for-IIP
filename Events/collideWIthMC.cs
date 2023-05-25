using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideWIthMC : MonoBehaviour
{
    private int waterPunchCounter = 0;
    public int TTKwater = 6;
    
    
    private void OnCollisionStay2D(Collision2D other)
    {
        GameObject collisionObject = other.gameObject;

        if (collisionObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                waterPunchCounter++;
                print($"punch:{waterPunchCounter}");
            }
            if (waterPunchCounter >= TTKwater)
            {
                Destroy(gameObject);
                waterPunchCounter = 0;
            }
        }
    }
}
