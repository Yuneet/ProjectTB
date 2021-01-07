using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTileCtrl : MonoBehaviour
{
    public float speed;
    public bool isMove;
    public float[] num;

    // Start is called before the first frame update
    void Start()
    {
        num = new float[2];
        num[0] = 0.56f;
        num[1] = 7.4f;
    }

    // Update is called once per frame
    void Update()
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
