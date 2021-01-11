using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColCtrl : MonoBehaviour
{
    public GameObject Feet = null;
    public BoxCollider2D box = null;
    public bool isUnder = true;
    public bool isNormal = false;
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y > Feet.transform.position.y)
        {
            //Debug.Log(1);
            isUnder = true;
            if (isNormal)
                box.enabled = false;
        }
        else
        {
            //Debug.Log(2);
            isUnder = false;
            if (isNormal)
                box.enabled = true;
        }
    }
}
