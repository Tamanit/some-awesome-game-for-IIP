using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeHandle : MonoBehaviour
{
    // Start is called before the first frame update

    private BoxCollider2D collider;
    private int dudeUpCounter = 0;
   
   

    private void Start()
    {
      
    }

    void Update()
    { }
   
    private void OnTriggerStay2D(Collider2D collider)
    {
        GameObject collisionObject = collider.gameObject;
        if (collisionObject.CompareTag("Plumper")|| collisionObject.CompareTag("Fireman"))
        {
            print("touch");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dudeUpCounter += 1;
                print("ыть");
            }
            if (dudeUpCounter >= 6)
            {
                Destroy(gameObject);
                dudeUpCounter = 0;
            }
        }
    }

}
