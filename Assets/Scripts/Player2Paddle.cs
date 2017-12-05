using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //save the mouse position in Umity units 
        //(depending on the number of units on screen)
        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 10f) - 7.5f;

        //creates a Vector3 which saves a coordinate
        //in (x,y,z)
        //this.transfrom.position.y: keeps the starting y-value
        Vector3 paddlePosition = new Vector3(2f, this.transform.position.x, 0f);

        //make the paddle move with the mouse
        paddlePosition.y = Mathf.Clamp(mousePosInUnits, 5f, -5f);
        //paddlePosition.x = Mathf.Clamp(myBall.transform.position.x, -7.5f, 7.5f);
        //Transform --> position, rotation or scale
        //set the position of the paddle (this) to paddlePosition
        this.transform.position = paddlePosition;
    }
}