﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour
{

    public float speed = 1;

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }

        // Use this for initialization
        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

}