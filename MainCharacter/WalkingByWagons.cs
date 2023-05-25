using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WalkingByWagons : MonoBehaviour
{
    public GameObject train;


    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject collisionObject = other.gameObject;

        switch (collisionObject.tag)
        {
            case "LeftDoor":
                train.transform.position += new Vector3(140, 0, 0);
                this.gameObject.transform.position = new Vector3(48, -7, 0);
                print("трогаю левую дверь");
                break;
            case "RightDoor":
                train.transform.position -= new Vector3(140, 0, 0);
                this.gameObject.transform.position = new Vector3(-48, -7, 0);
                print("трогаю правую дверь");
                break;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        GameObject collisionObject = other.gameObject;

        switch (collisionObject.tag)
        {
            case "LeftDoorLocked":
                this.gameObject.transform.position += new Vector3(2, 0, 0);
                print("трогаю левую дверь");
                break;
            case "RightDoorLoked":
                this.gameObject.transform.position -= new Vector3(2, 0, 0);
                print("трогаю правую дверь");
                break;
        }
    }
}
