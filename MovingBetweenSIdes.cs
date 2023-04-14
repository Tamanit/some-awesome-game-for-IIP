using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBetweenSIdes : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "sideWayTrigger")
            print("toch");
    }
}
