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
        float mousePosInUnits = (Input.mousePosition.y / Screen.height*10f) -5f;
        Debug.Log(mousePosInUnits);

        Vector3 Player2Position = new Vector3(this.transform.position.x, 2f, 1f);

        Player2Position.y = Mathf.Clamp(mousePosInUnits, -4.1f, 4.1f);
        this.transform.position = Player2Position;
    }
}