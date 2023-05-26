using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DudeHandle : MonoBehaviour
{
    // Start is called before the first frame update

    private BoxCollider2D collider;
    private int dudeUpCounter = 0;
    public ScoreOnDestroy score;
    

    private void Awake()
    {
        score = GameObject.Find("Score").GetComponent<ScoreOnDestroy>();
    }
    
    private void OnTriggerStay2D(Collider2D collider)
    {
        GameObject collisionObject = collider.gameObject;
        if (collisionObject.CompareTag("Plumper") || collisionObject.CompareTag("Fireman"))
        {
            print("touch");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.transform.position += new Vector3(0, 1, 0);
                dudeUpCounter += 1;
                print("���");
            }
            if (dudeUpCounter >= 6)
            {
                score.AddToScore(1);
                Destroy(gameObject);
            }
        }
    }

}
