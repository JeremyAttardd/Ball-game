using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour {


    public Text ScoreP1;
    private int Score;
    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (Score == 2)
        {
            myLevelManager.LoadLevel("Level2");
        }
        else
        {
            Score += 1;
            
        }

    }

    
    // Use this for initialization
    void Start()
    {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {

        ScoreP1.text = Score.ToString();

    }
}


