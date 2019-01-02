using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   private float speed;
   private  Rigidbody rb;
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(-transform.up * 500);
           
        }
         rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        this.speed = 0.01f;
       
            if (transform.position.y < 1)
            {
              transform.Translate(new Vector3(0, 6.0f, 0) * speed);
              rb.useGravity = true;
            }
    }


    
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.up * 500);
        
    }
}
