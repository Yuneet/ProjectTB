﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTileCtrl : MonoBehaviour
{
    
    public float speed;
    public bool isMove;
    public float leftx;
    public float rightx;

    // Start is called before the first frame update
    void Start()
    {
        //startx = -4.45f;
        //lastx = 6.83f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x <= leftx)
        {
            isMove = true;
        }else if (transform.position.x >= rightx)
        {
            isMove = false;
        }
        if (isMove == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (isMove == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
    }
}
