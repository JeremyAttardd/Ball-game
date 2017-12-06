using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private bool hasStarted = false;
    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Top Border")
        {
            randomY = Random.Range(-0.5f, 0f);
            Vector2 tweak = new Vector2(randomX, randomY);

            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
        else
        {

            Vector2 tweak = new Vector2(randomX, randomY);

            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) // Left click
        {

            hasStarted = true;

            //Applies a velocity of 2x and10y to the ball
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 2f);

        }

    }
}
