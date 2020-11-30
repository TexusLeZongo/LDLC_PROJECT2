using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheremoove : MonoBehaviour
{
    Rigidbody rigidbody;
    
   
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        float speed = 4f;
        Vector3 currentPosition = transform.position;
        Vector3 moveForward = transform.forward;
        
        

        Vector3 newPosition = currentPosition + moveForward * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);


    }

        
    
        
}
