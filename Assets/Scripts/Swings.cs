using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swings : MonoBehaviour
{
    public bool canActive = false;
    public bool TurnRight = true;
    public float speed = 1;
    public float angle = 0;
    public float LeftAngle = 0;
    public float RightAngle = 0;

    void FixedUpdate()
    {
        if (angle < LeftAngle)
        {
            TurnRight = true;
        }
        if (angle > RightAngle)
        {
            TurnRight = false;
        }

        if (TurnRight)
        {
            angle += speed;
        }
        else
        {
            angle -= speed;
        }
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
