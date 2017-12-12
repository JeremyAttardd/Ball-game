using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour{

    private float Speed = 10;
    private float Length = 4.1f;

    void Update()
    {

        Vector3 position = this.transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Speed * Time.deltaTime;
            Mathf.Clamp(transform.position.y, -4.1f, 4.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Speed * Time.deltaTime;
        }

        var pos = transform.position;
        if (pos.y > Length)
        {
            pos.y = Length;
        }
        if (pos.y < -Length)
        {
            pos.y = -Length;
        }
        transform.position = pos;

    }





}