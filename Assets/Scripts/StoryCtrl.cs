﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    private float SeenNumners;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameObject8;
    public GameObject gameObject9;
    public GameObject gameObject10;
    public Text text;


    void Awaek()
    {
        SeenNumners = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (SeenNumners == 0)
        {
            gameObject1.SetActive(true);
            gameObject10.SetActive(false);
            text.text = "1";
        }else if (SeenNumners == 1)
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
            text.text = "2";
        }
        else if (SeenNumners == 2)
        {
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
            text.text = "3";
        }
        else if (SeenNumners == 3)
        {
            gameObject3.SetActive(false);
            gameObject4.SetActive(true);
            text.text = "4";
        }
        else if (SeenNumners == 4)
        {
            gameObject4.SetActive(false);
            gameObject5.SetActive(true);
            text.text = "5";
        }
        else if (SeenNumners == 5)
        {
            gameObject5.SetActive(false);
            gameObject6.SetActive(true);
            text.text = "6";
        }
        else if (SeenNumners == 6)
        {
            gameObject6.SetActive(false);
            gameObject7.SetActive(true);
            text.text = "7";
        }
        else if (SeenNumners == 7)
        {
            gameObject7.SetActive(false);
            gameObject8.SetActive(true);
            text.text = "8";
        }
        else if (SeenNumners == 8)
        {
            gameObject8.SetActive(false);
            gameObject9.SetActive(true);
            text.text = "9";
        }
        else if (SeenNumners == 9)
        {
            gameObject9.SetActive(false);
            gameObject10.SetActive(true);
            text.text = "10";
        }else if (SeenNumners == 10)
        {
            SeenNumners = 0;
        }

    }

    public void OnCrick()
    {
        SeenNumners += 1;
    }
}
