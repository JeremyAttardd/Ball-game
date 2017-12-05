using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{

    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Player 1 scored ");
        myLevelManager.LoadLevel("Win");
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
