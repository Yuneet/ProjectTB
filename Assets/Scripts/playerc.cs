﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerc : MonoBehaviour
{
    public float speed;
    public bool isJump = false;
    public float jump;
    public Animator at;
    public SpriteRenderer sprite;
    public Rigidbody2D rigid;
    public Collision2D collision2D;
    //내 캐릭터의 발의 위치
    public Transform feetPos;
    //발의 위치에서 체크할 위치
    public float checkRadius;
    //바닥이 같은 레이어인지 체크하기 위해 레이어설정
    public LayerMask layer;
    public bool istag;
    public AudioClip audioJump;
    public AudioClip audioRun;
    public AudioClip audioDamaged;
    public AudioSource sfx;
    // Start is called before the first frame update
    private bool leftBtn = false;
    private bool rightBtn = false;
    cameracc cameracc;
    //ghygh
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        at = GetComponent<Animator>();
        sfx = GetComponent<AudioSource>();
        cameracc = GameObject.Find("Main Camera").GetComponent<cameracc>();
    }

    // Update is called once per frame
    void Update()
    {
        isJump = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);

        //input.GetKeyDown == 키를 한번 눌렸을때
        //input.GetKeyUp == 누른 키를 땟을때
        //input.GetKey == 키를 계속 누르고 있을때

        if(GetComponent<Rigidbody2D>().velocity.normalized.y > 0)
        {
            at.SetBool("isJump", true);
        }

        if(GetComponent<Rigidbody2D>().velocity.normalized.y < 0)
        {
            at.SetBool("isJump", false);
            at.SetBool("isFall", true);
        }

        if(GetComponent<Rigidbody2D>().velocity.normalized.y == 0)
        {
            at.SetBool("isFall", false);
        }

        //Debug.Log("velocity : " + GetComponent<Rigidbody2D>().velocity.normalized);

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
           
            at.SetBool("isRun", false);
            StopSound();
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            //GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<SpriteRenderer>().flipX = true;
            at.SetBool("isRun", true);
            RunSound();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            //GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<SpriteRenderer>().flipX = false;
            at.SetBool("isRun", true);
            RunSound();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isJump == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump;
            JumpSound();
        }

        if(leftBtn == true && rightBtn == false)
        {
            //Debug.Log("왼쪽왼쪽");
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;
            at.SetBool("isRun", true);
            RunSound();
        }
        
        if (rightBtn == true && leftBtn == false)
        {
            //Debug.Log("오른쪽오른쪽");
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
            at.SetBool("isRun", true);
            RunSound();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Saw")
        {
            OnDamaged(collision.transform.position);
            istag = true;
            cameracc.OnShakeCamera();
        }
    }
    public void OnDamaged(Vector2 targetPos)
    {
        gameObject.layer = 11;

        sprite.color = new Color(1, 1, 1, 0.4f);
        rigid.velocity = new Vector2(0, 0);
        //dirc == 피격데미지를 입고 뒤로 밀려나는 범위
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
        rigid.AddForce(new Vector2(dirc , 1) * 5.5f, ForceMode2D.Impulse);
        Invoke("OffDamaged", 1.5f);
        DamagedSound();
    }

    public void OffDamaged()
    {
        gameObject.layer = 10;
        sprite.color = new Color(1, 1, 1, 1);
        istag = false;
    }

    public void DamagedSound()
    {

        sfx.PlayOneShot(audioDamaged);
    }
    public void JumpSound()
    {
        sfx.PlayOneShot(audioJump);
    }
    public void RunSound()
    {
        if (sfx.isPlaying == false)
        {
            sfx.loop = false;
            sfx.PlayOneShot(audioRun);
        }
        
    }
    public void StopSound()
    {
        sfx.Stop();
    }

    public void leftOnPointerDown()
    {
        leftBtn = true;
    }

    public void leftOnPointerUp()
    {
        leftBtn = false;
        StopSound();
    }

    public void rightOnPointerDown()
    {
        rightBtn = true;
    }

    public void rightOnPointerUp()
    {
        rightBtn = false;
        StopSound();
    }

    public void jumps()
    {
        if (isJump == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jump;
            JumpSound();
        }
        else if (isJump == false)
        {
            StopSound();
        }
    }
}
