﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = transform.position + Vector3.up * 0.5f + transform.forward * 0.5f;
            Instantiate(sphere,position,transform.rotation);
        }
        
    }
}
