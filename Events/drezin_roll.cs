using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class drezin_roll : MonoBehaviour
{
    private Rigidbody2D rb;
    private float counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(60f, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         counter+= 1*Time.deltaTime;
        if (transform.position.x>0&& transform.position.x<1)
        {
            rb.Sleep();
        }
            

        if (counter > 9)
        {           
            rb.WakeUp();
            rb.velocity = new Vector2(60f, 0);
            counter = 0;
        }
        if (transform.position.x > 144)
            Destroy(gameObject);
    }


}
