using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

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

    public float timerxx = 0;

    // 좌표가 양수인지 음수인지 정해주는 선언
    public bool Ham;

    SpriteRenderer PlayerFilp;


    void Awake()
    {
        timerx = -0.1f;
        timery = -0.1f;
        PlayerFilp = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {
        
        // X축으로 이동하는 트랩 설정
        if (Check == true)
        {
            if (transform.position.x < StartPoint && Ham == true && timerx < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x + 0.02f, transform.position.y);
                // X는 -축이 왼쪽 , +축이 오른쪽인데, 현재 StartPoint가 5라고 가정을 해보자
                // Dir = false가 되었을 때는 왼쪽으로 게속 이동을 할 것이다
                // 그러면 x 좌표가 5를 넘어서는 순간 StartPoint보다 크다고 인식을 하여
                // Dir = true로 설정 시킨다.
                Dir = true;
                timerx = timerxx;
                PlayerFilp.flipX = true;
            }
            else if (transform.position.x > EndPoint && Ham == true && timerx < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x-0.02f, transform.position.y);
                // Dir = true가 되었을 때는 왼쪽으로 이동을 할 것이다
                // 근데 x축으로 왼쪽으로 이동하는건 음수로 넘어간다 / EndPoint는 -5라고 가정한다
                // 트랩이 -5를 넘어서 가게 되는 순간에 EndPoint보다 현재 트랩의 X축 좌표가 작다고 판정하여
                // Dir = false로 설정 시킨다.
                Dir = false;
                timerx = timerxx;
                PlayerFilp.flipX = false;

            }
        }
        if (Check == true)
        {
            if (transform.position.x > StartPoint && Ham == false && timerx < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x - 0.02f, transform.position.y);
                // X는 -축이 왼쪽 , +축이 오른쪽인데, 현재 StartPoint가 5라고 가정을 해보자
                // Dir = false가 되었을 때는 오른쪽으로 게속 이동을 할 것이다
                // 그러면 x 좌표가 5를 넘어서는 순간 StartPoint보다 크다고 인식을 하여
                // Dir = true로 설정 시킨다.
                Dir = false;
                timerx = timerxx;
            }
            else if (transform.position.x < EndPoint && Ham == false && timerx < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x + 0.02f, transform.position.y);
                // Dir = true가 되었을 때는 왼쪽으로 이동을 할 것이다
                // 근데 x축으로 왼쪽으로 이동하는건 음수로 넘어간다 / EndPoint는 -5라고 가정한다
                // 트랩이 -5를 넘어서 가게 되는 순간에 EndPoint보다 현재 트랩의 X축 좌표가 작다고 판정하여
                // Dir = false로 설정 시킨다.
                Dir = true;
                timerx = timerxx;

            }
        }

        if (Check == false && Ham == true)// Y축으로 이동하는 트랩 설정
        {
            if (transform.position.y > StartPoint && transform.position.y < EndPoint && timery < 0) // Y축은 아래가 - 음수이기 때문에 작다고 판정해야함
            {
                gameObject.transform.position = new Vector2(transform.position.x, transform.position.y+0.02f);
                Dir = true;
                timery = timerxx;
            }
            else if (transform.position.y > EndPoint && timery < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x, transform.position.y-0.02f);
                Dir = false;
                timery = timerxx;
            }
        }
        if (Check == false && Ham == false)// Y축으로 이동하는 트랩 설정
        {
            if (transform.position.y < StartPoint && timery < 0) // Y축은 아래가 - 음수이기 때문에 작다고 판정해야함
            {
                gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + 0.02f);
                Dir = true;
                timery = timerxx;
            }
            else if (transform.position.y > EndPoint && timery < 0)
            {
                gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - 0.02f);
                Dir = false;
                timery = timerxx;
            }
        }

        if (timerx > 0)
        {
            timerx -= Time.deltaTime * 0.25f;
        }
        if (timery > 0)
        {
            timery -= Time.deltaTime * 0.25f;
        }

        if (Check == true && timerx < 0)
        {
            if (Dir == true)
            {
                PlayerFilp.flipX = true;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                PlayerFilp.flipX = false;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        else if (Check == false && timery < 0)
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
        
        


    }

