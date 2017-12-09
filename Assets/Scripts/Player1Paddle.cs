using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour{

    private float Speed;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        Speed = 5;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float axisX = Input.GetAxis("Vertical");
        float axisY = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(axisY, axisX) * Time.deltaTime * Speed);
    }
}