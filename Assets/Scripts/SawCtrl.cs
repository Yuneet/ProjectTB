/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // 트랩이 움직이는 속력
    public float speed;
    // End 지점을 설정
    public float EndPoint;
    // Start 지점을 설정
    public float StartPoint;

    // X축을 이동할거냐 Y축을 이동할거냐 정하는 것
    // 유니티 들어가서 따로 체크항목에 체크를 해서 True or False로 지정 해줘야함
    // True : X축 , False : Y축
    public bool Check;
    // EndPoint와 StartPoint, 어느 방향으로 이동 할건가 정해줌
    public bool Dir;

    // 몇초 멈춰있을지 정하는 곳
    public float timery = 0;
    public float timerx = 0;
    // 움직일지 아닐지 정하는 곳
    public bool TxSwich = true;
    public bool TySwich;


    void Awake()
    {
        timerx = 1;
    }


    void Update()
    {
        // X축으로 이동하는 트랩 설정
        if (Check == true)
        {
            if (transform.position.x > StartPoint && TxSwich == true)
            {
                // X는 -축이 왼쪽 , +축이 오른쪽인데, 현재 StartPoint가 5라고 가정을 해보자
                // Dir = false가 되었을 때는 오른쪽으로 게속 이동을 할 것이다
                // 그러면 x 좌표가 5를 넘어서는 순간 StartPoint보다 크다고 인식을 하여
                // Dir = true로 설정 시킨다.
                Dir = true;
                timerx = 1;
                TxSwich = false;
            }
            else if (transform.position.x < EndPoint && TxSwich == true)
            {
                // Dir = true가 되었을 때는 왼쪽으로 이동을 할 것이다
                // 근데 x축으로 왼쪽으로 이동하는건 음수로 넘어간다 / EndPoint는 -5라고 가정한다
                // 트랩이 -5를 넘어서 가게 되는 순간에 EndPoint보다 현재 트랩의 X축 좌표가 작다고 판정하여
                // Dir = false로 설정 시킨다.
                Dir = false;
                timerx = 1;
                TxSwich = false;
            }
        }
        else // Y축으로 이동하는 트랩 설정
        {
            if (transform.position.y < StartPoint && timery == 0) // Y축은 아래가 - 음수이기 때문에 작다고 판정해야함
            {
                Dir = true;
                timery = 1;
            }
            else if (transform.position.y > EndPoint && timery == 0)
            {
                Dir = false;
                timery = 1;
            }
        }

        if (Check == true && timerx < 0)
        {
            if (Dir == true)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                TxSwich = true;
            }
            else
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                TxSwich = true;
            }
        }
        else if (Check == false)
        {
            if (Dir == true)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
        }


    }
}*/





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawCtrl : MonoBehaviour
{
    public float Sawspeed;
    public Transform tf;
    public bool xc;
    public float [] qo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (tf.position.x <= -10.39) //-10.39f
        {
            xc = true;
        }
        else if (tf.position.x > 8.56) //8.56
        {
            xc = false;
        }
        



        if (xc == true)
        {

            transform.Translate(Vector2.right * Sawspeed * Time.deltaTime);
        }
        else if (xc == false)
        {
            transform.Translate(Vector2.left * Sawspeed * Time.deltaTime);
        }
    }
}
