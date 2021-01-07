using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTileCtrl : MonoBehaviour
{
    
    public float speed;
    public bool isMove;
    public float[] num = new float[2];

    // Start is called before the first frame update
    void Start()
    {
        num[0] = -4.45f;
        num[1] = 6.83f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x <= num[0])
        {
            isMove = true;
        }else if (transform.position.x >= num[1])
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
