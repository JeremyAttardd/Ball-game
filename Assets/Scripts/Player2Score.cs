﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Score : MonoBehaviour {

    int Score = 0;
    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score == 3)
        {
            myLevelManager.LoadLevel("Level2");
        }
        else
        {
            Score++;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.name);

    }

    // Use this for initialization
    void Start()
    {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}