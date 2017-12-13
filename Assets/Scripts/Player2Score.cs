using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Score : MonoBehaviour {

    public Text ScoreP2;
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

        ScoreP2.text = Score.ToString();

    }
}
