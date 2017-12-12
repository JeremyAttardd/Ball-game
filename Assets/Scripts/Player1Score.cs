using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour {


    public Text Score;
    int Scoree;
    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (Scoree == 2)
        {
            myLevelManager.LoadLevel("Level2");
        }
        else
        {
            Scoree += 1;
            Score.text = "" + Scoree;
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
