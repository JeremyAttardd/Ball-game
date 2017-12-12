﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ScoreLvl3 : MonoBehaviour {

    int Scoree;
    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (Scoree == 6)
        {
            myLevelManager.LoadLevel("Level2");
        }
        else
        {
            Scoree += 1;

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