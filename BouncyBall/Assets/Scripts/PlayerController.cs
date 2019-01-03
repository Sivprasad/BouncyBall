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
            OnMouseDown();
        }
        rb = GetComponent<Rigidbody>();
        this.speed = 0.01f;

    }


    void FixedUpdate()
    {
         
       
        if (transform.position.y < 1)
        {
           
            transform.Translate(new Vector3(0, 5.0f, 0) * speed);
        }



    }



    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.up * 500);
        rb.useGravity = true;
    }
}
