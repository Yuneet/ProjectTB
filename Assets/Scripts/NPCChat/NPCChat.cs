﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NPCChat : MonoBehaviour
{
    // Start is called before the first frame update
    public int Swichs = 0;
    public bool Check;
    private bool iscaech;
    private bool isbutten;
    public GameObject gameObject1;
    public GameObject gameObject11;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject33;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameObject77;
    public GameObject gameObject777;
    public GameObject gameObject8;
    public GameObject Endimage1;
    public GameObject Sign;
    //public Canvas Can;
    public GameObject can;
    public GameObject block;
    public Text text;
    public Text textname;
    public float K;
    public GameObject P;
    public BoxCollider2D box;
    public GameObject Npc;
    public GameObject can2;

    public GameObject Btn;
    public Text text2;
    public GameObject text1;
    public GameObject textname1;

    public playerc playerc;
    public potal potal;
    public GameObject door;
    public GameObject Em;
    public cameracc cameracc;
    public AudioSource audioSource;
    public AudioClip audioClips;
    //public bool isFlip;


    void Awaek()
    {
        Swichs = 0;

    }

    void Start()
    {
        can.SetActive(false);
        gameObject1.SetActive(false);
        gameObject11.SetActive(false);
        gameObject2.SetActive(false);
        gameObject3.SetActive(false);
        gameObject33.SetActive(false);
        gameObject4.SetActive(false);
        gameObject5.SetActive(false);
        gameObject6.SetActive(false);
        gameObject7.SetActive(false);
        gameObject77.SetActive(false);
        gameObject777.SetActive(false);
        gameObject8.SetActive(false);
   
        //Endimage1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnCricks();
        }



        if (K == 0 || K == 2 || K == 4 || K == 6 || K == 8 || K == 10 || K == 12 || K == 14 || K == 16 || K == 18 || K == 20 || K == 22)
        {
            Swichs = 0;
        }
        // 떨어지는 장면
        if (K == -1)
        {
            if (Swichs == 0)
            {
                gameObject3.SetActive(false);
                Btn.SetActive(false);
                can.SetActive(true);
                gameObject8.SetActive(true);
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                if (iscaech == false)
                {
                    StartCoroutine(massage("기다리고 있었습니다, 고오고님 되십니까?"));
                }
                SC();
            }
            else if (Swichs == 1)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 끄덕거린다 '"));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                if (iscaech == false)
                {
                    gameObject8.SetActive(false);
                    StartCoroutine(massage("이쪽으로 오시지요, 안내해드리겠습니다"));
                }
                SC();
            }
            else if (Swichs == 3)
            {
                Btn.SetActive(true);
                K = 0;
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(0.08f, 4.53f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

        /*if (P.transform.position.x >= 1.25f)
        {
            block.SetActive(true);
        }*/

        // 첫 스테이지 시작
        if (K == 1)
        {
            if (Swichs == 0)
            {
                gameObject3.SetActive(false);
                Btn.SetActive(false);
                can.SetActive(true);
                door.SetActive(false);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                //text.text = "일단 이곳을 탈출 하는게 우선이겠군"; 이전꺼
                if (iscaech == false)
                {
                    StartCoroutine(massage("여기가 어디지.. ? 그녀를 따라가긴 했는데"));
                }
                Go();
            }
            else if (Swichs == 1)
            {
                //text.text = "일단 이곳을 탈출 하는게 우선이겠군"; 이전꺼
                if (iscaech == false)
                {
                    StartCoroutine(massage("진정하자, 일단 이곳을 탈출 하는게 우선이겠군"));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                Btn.SetActive(true);
                K = 2;
                can.SetActive(false);


                Swichs = 0;
                Npc.transform.position = new Vector3(0.08f, 4.53f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

        // 첫 스테이지 발판 앞에 두고
        if (K == 3)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("왠지 느낌이 좋지 않아, 조심해야겠군"));
                }
                Go();
            }
            else if (Swichs == 1)
            {
                Btn.SetActive(true);
                K = 4;
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(9.5f, 8.5f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

        // 첫 스테이지 포탈을 앞두고
        if (K == 5)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("이곳을 통하면 다음 층으로 향할 수 있는건가"));
                }
                Go(); 

            }
            else if (Swichs == 1)
            {
                Btn.SetActive(true);
                K = 6;
                can.SetActive(false);
                Em.SetActive(true);
                Swichs = 0;
                Npc.transform.position = new Vector3(12.82f, 13.39f, -1f);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }

        // 첫 스테이지 포탈을 탄 후
        if (K == 7)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                gameObject3.SetActive(true);
                can.SetActive(true);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("인간이 여기까지 들어오다니 제법이구나 ?"));
                }
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject3.SetActive(false);
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject11.SetActive(false);
                gameObject5.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("들었으면 대답이라도 하지 그래 ?"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("넌 누구고 여기는 어디지 ?"));
                }
                Go();
            }
            else if (Swichs == 4)
            {
                gameObject4.SetActive(true);
                gameObject5.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그건 알 것 없고, 너도 유물이 탐나나봐 ?"));
                }
                Sp();
            }
            else if (Swichs == 5)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그 유물에 대해서 아는것이 있는건가 ?"));
                }
                Go();
            }
            else if (Swichs == 6)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("지금은 알려줄 수 없고 ~, 다음 곳 까지 오면 알려주지~"));
                }
                Sp();
            }
            else if (Swichs == 7)
            {
                gameObject4.SetActive(false);
                if (iscaech == false)
                {
                    textname1.SetActive(false);
                    Vector3 position = text.transform.localPosition;
                    position.y = -19.36f;
                    text.transform.localPosition = position;
                    StartCoroutine(massage("' 스핑크스는 메롱 표정을 지으며 사라졌다 '"));
                }
            }
            else if (Swichs == 8)
            {
                if (iscaech == false)
                {
                    textname1.SetActive(true);
                    Vector3 position = text.transform.localPosition;
                    position.y = -20f;
                    text.transform.localPosition = position;
                    //text.rectTransform.position = new Vector3(1.32f, -18.68f, -300);
                    StartCoroutine(massage("뭐하는 녀석인지.."));
                }
                Go();
            }
            else if (Swichs == 9)
            {
                Btn.SetActive(true);
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-1.46f, 34.53f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                K = 8;
            }
        }

        // 첫 갈림길에 서서
        if (K == 9)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                if (iscaech == false)
                {
                    StartCoroutine(massage("옛날 기분이 나는군... 그때가 말이야"));
                }
                Go();
            }
            else if (Swichs == 1)
            {
                Btn.SetActive(true);
                can.SetActive(false);
                Em.SetActive(true);
                Swichs = 0;
                Npc.transform.position = new Vector3(-5.11f, 51.21f, -1f);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                K = 10;
            }
        }

        // 첫 스테이지 두번째 포탈을 탄 후
        if (K == 11)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                gameObject3.SetActive(true);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("인간 주제에 여기까지 오다니 !, 이몸이 칭찬해주지 !"));
                }
                Sp();
            }
            else if (Swichs == 1)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그러니까 너가 누구냔 말이다"));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject3.SetActive(false);
                gameObject6.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("아 거참, 말이 많네?, 내가 누군지 모른단 말이야 ?"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("너는 자기소개도 안하는데, 누군지 알아야해 ?"));
                }
                Go();
            }
            else if (Swichs == 4)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그럼 난 누군데, 알아맞춰봐"));
                }
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject11.SetActive(true);
                gameObject6.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Sp();
            }
            else if (Swichs == 6)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("바보"));
                }
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject2.SetActive(true);
                gameObject11.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("ㅁ..뭐? 바보? 죽고싶어 ?"));
                }
                Sp();
            }
            else if (Swichs == 8)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그래서 유물의 능력이 뭔지 알고 있는건가 ?"));
                }
                Go();
            }
            else if (Swichs == 9)
            {
                gameObject3.SetActive(true);
                gameObject2.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너 같은 하등한 존재가 느낄 수 없는 어마무시한 유물이지~"));
                }
                Sp();
            }
            else if (Swichs == 10)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Go();
            }
            else if (Swichs == 11)
            {
                gameObject1.SetActive(true);
                gameObject3.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("어이.. 들었으면 대답을 하라니까?"));
                }
                Sp();
            }
            else if (Swichs == 12)
            {
                gameObject5.SetActive(true);
                gameObject1.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("안되겠다, 넌 다시 처음부터 시작하자"));
                }
                Sp();
            }
            /*else if (Swichs == 13)
            {
                block.SetActive(false);
            }*/
            else if (Swichs == 13)
            {
                //block.SetActive(true);
                gameObject1.SetActive(true);
                gameObject5.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("다시 올라와~ 그러면 내가 친히 설명해주지 !"));
                }
                Sp();
                //can.SetActive(false);
                Npc.transform.position = new Vector3(-6.92f, -3.35f, 0);
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
            else if (Swichs == 14)
            {
                can.SetActive(false);
                Sign.SetActive(false);
                StartCoroutine(Down());
                //
            }
            else if (Swichs == 15)
            {
                can.SetActive(true);
                Sign.SetActive(true);
                gameObject1.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너 딱 거기서 기다려라.."));
                }
                Go();

            }
            else if (Swichs == 16)
            {
                K = 12;
                can.SetActive(false);
                Btn.SetActive(true);
                door.SetActive(true);
                Swichs = 0;
                Npc.transform.position = new Vector3(200f, 500f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }

        // 두번째 스테이지 도착
        if (K == 13)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                Em.SetActive(false);
                gameObject1.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("너 근데, 여기 오게 된 이유가 뭐야?"));
                }
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Go();
            }
            if (Swichs == 2)
            {
                gameObject11.SetActive(false);
                gameObject4.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("누군가가 여길 알려줬나?, 편지로? ㅎㅎㅎ"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그게 너였구나?"));
                }
                Go();
            }
            if (Swichs == 4)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("아니~?, 난 모르겠는걸?"));
                }
                Sp();
            }
            else if (Swichs == 5)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("어쨋든 난 그 유물을 꼭 찾아야겠어, 어서 길을 알려줘"));
                }
                Go();
            }
            if (Swichs == 6)
            {
                gameObject4.SetActive(false);
                gameObject6.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너가 그 유물을 찾던 난 관심없어"));
                }
                Sp();
            }
            if (Swichs == 7)
            {
                gameObject6.SetActive(false);
                gameObject3.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("내가 너무 심심해서 말이지, 얼른 이동해주면 안될까?"));
                }
                Sp();
            }
            else if (Swichs == 8)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("아무래도 그럴 참이였다, 너무 오래있으면 짜증날 것 같아서 말이지"));
                }
                Go();
            }
            else if (Swichs == 9)
            {
                gameObject3.SetActive(false);
                gameObject2.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그거 지금 나보고 하는 소리야?"));
                }
                Sp();
            }
            else if (Swichs == 10)
            {
                K = 14;
                Btn.SetActive(true);
                can.SetActive(false);
                Em.SetActive(true);
                gameObject2.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-20.18f, -4.06f, 0);
                box.enabled = true;

            }
        }

        // 두번째 스테이지 첫번째 포탈 도착
        if (K == 15)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                Em.SetActive(false);
                gameObject1.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("그런데, 넌 유물을 얻어서 뭘 하는데 쓰려고 하는거야 ?"));
                }
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그것까진 너가 알 것 없겠군"));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject11.SetActive(false);
                gameObject5.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("으 진짜 짜증나는 타입이네"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject5.SetActive(false);
                gameObject6.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너 여자친구 없지 ?"));
                }
                Sp();
            }
            else if (Swichs == 4)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject6.SetActive(false);
                gameObject3.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("푸하핫, 장난이야 장난"));
                }
                Sp();
            }
            else if (Swichs == 6)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("유물은 사용자에게 반드시 무언가 하나를 안겨줘"));
                }
                Sp();
            }
            else if (Swichs == 7)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("돈이면 돈, 명예면 명예..."));
                }
                Sp();
            }
            else if (Swichs == 8)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("너무 큰 욕심만 아니면 너에게 곧 일어나게 될거야"));
                }
                Sp();
            }
            else if (Swichs == 9)
            {
                gameObject3.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("'팀원들을 다시 만날수도 .. 있는건가..."));
                }
                Go();
            }
            else if (Swichs == 10)
            {
                Btn.SetActive(true);
                K = 16;
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-36.48f, 1.24f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

        // 두번째 스테이지 포탈 이동 후
        if (K == 17)
        {
            if (Swichs == 0)
            {
                gameObject3.SetActive(false);
                Btn.SetActive(false);
                can.SetActive(true);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                if (iscaech == false)
                {
                    StartCoroutine(massage("이정도 지대면 충분히 빠른 시일내에 이동이 가능하겠군"));
                }
                Go();
            }
            else if (Swichs == 1)
            {
                Btn.SetActive(true);
                K = 18;
                can.SetActive(false);
                Em.SetActive(true);
                Swichs = 0;
                Npc.transform.position = new Vector3(-17.59f, 35.87f, -1f);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            }
        }

        // 두번째 스테이지 두번째 포탈 도착
        if (K == 19)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                can.SetActive(true);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                gameObject1.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너 이런곳에 와보는거 한 두번이 아니구나?"));
                }
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("난 유물이 있다면 어디든지 탐험을 했지, 그랬었지.."));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject1.SetActive(true);
                gameObject11.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그랬었지..?, 그게 무슨 말이야?"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("아무것도 아니다, 그래서 난 어디쯤 까지 온 것이지?"));
                }
                Go();
            }
            else if (Swichs == 4)
            {
                gameObject33.SetActive(true);
                gameObject11.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너무 서두르는 것 아니야?"));
                }
                Sp();
            }
            else if (Swichs == 5)
            {
                gameObject4.SetActive(true);
                gameObject33.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("내가 그렇게 쉽게 줄 것 같아?"));
                }
                Sp();
            }
            else if (Swichs == 6)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("너가 준다는 말인가?"));
                }
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject4.SetActive(false);
                gameObject2.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("아..아니?, 그게 무슨 말이야? 내가 언제 그랬다고 !"));
                }
                Sp();
            }
            else if (Swichs == 8)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("바보같은 놈, 표정에 티 다난다"));
                }
                Go();
            }
            else if (Swichs == 9)
            {
                gameObject2.SetActive(false);
                gameObject5.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("너가 한번 더 떨어져봐야 정신을 차리겠구나 ^^?"));
                }
                Sp();
            }
            else if (Swichs == 10)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그런데 너는 어째서 이곳에 있는거지 ?"));
                }
                Go();
            }
            else if (Swichs == 11)
            {
                gameObject5.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 못들은 척 하더니, 어디론가 가버렸다 '"));
                }
                Go();
            }
            else if (Swichs == 12)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("...?"));
                }
                Go();
            }
            else if (Swichs == 13)
            {
                Btn.SetActive(true);
                K = 20;
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-100f, 100f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

        if (K == 21)
        {
            if (Swichs == 0)
            {
                audioSource.clip = audioClips;
                audioSource.Play();
                Btn.SetActive(false);
                can.SetActive(true);
                Em.SetActive(false);
                playerc.rightBtn = false;
                playerc.leftBtn = false;
                gameObject11.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("벌써 빛이 보이는구나 그런데 유물은 어디있지 ? "));
                }
                Go();
            }
            else if (Swichs == 1)
            {
                gameObject11.SetActive(false);
                gameObject3.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("왜이리 성급하냐구~ 난 아직 심심한데"));
                }
                Sp();
            }
            else if (Swichs == 2)
            {
                gameObject777.SetActive(true);
                gameObject3.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 자신이 쓰고있던 왕관을 건넨다 '"));
                }
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject777.SetActive(false);
                gameObject77.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("자 너가 그렇게 찾아 해매던 유물이다 !"));
                }
                Sp();
            }
            else if (Swichs == 4)
            {
                gameObject77.SetActive(true);
                gameObject777.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("..."));
                }
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject77.SetActive(false);
                gameObject7.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("난 이제 원하던 것을 얻은 것 같아서 말이야"));
                }
                Sp();
            }
            else if (Swichs == 6)
            {
                gameObject7.SetActive(false);
                gameObject777.SetActive(true);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그게 무슨 말이지 ?"));
                }
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject7.SetActive(true);
                gameObject777.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("난 말이야, 수천년동안 이곳에 갇혀있었어"));
                }
                Sp();
            }
            else if (Swichs == 8)
            {
                gameObject77.SetActive(true);
                gameObject7.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("이 신전을 지키기 위해서 말이지"));
                }
                Sp();
            }
            else if (Swichs == 9)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("혹시나 그 편지를 보낸건 너인가 ?"));
                }
                Go();
            }
            else if (Swichs == 10)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("심심했을 뿐이야, 오랜시간 그 누구도 보지 못했거든"));
                }
                Sp();
            }
            else if (Swichs == 11)
            {
                gameObject777.SetActive(true);
                gameObject77.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("그런가, 많은 탐험가들이 이곳을 오지 않았어 ?"));
                }
                Go();
            }
            else if (Swichs == 12)
            {
                gameObject77.SetActive(true);
                gameObject777.SetActive(false);
                if (iscaech == false)
                {
                    StartCoroutine(massage("옛날에는 그랬지, 이젠 그 누구도 찾아오지 않아"));
                }
                Sp();
            }
            else if (Swichs == 13)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("'그녀는 단지 사람의 손길이 그리웠던 것 인걸까..'"));
                }
                Go();
            }
            else if (Swichs == 14)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("장난이 심했다면 사과할게, 이제 이 곳을 나가봐도 좋아"));
                }
                Sp();
            }
            else if (Swichs == 15)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("너는 어떻게 할 셈이야? 이곳을 나가지 않고"));
                }
                Go();
            }
            else if (Swichs == 16)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("그동안 즐거웠어, 나에겐 돌아갈 곳이 없거든"));
                }
                Sp();
            }
            else if (Swichs == 17)
            {
                gameObject77.SetActive(false);
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 그 말을 뒤로 그녀는 모습을 감췃다 '"));
                }
                Go();
            }
            else if (Swichs == 18)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("돌아갈 곳이 없다니, 그게 무슨 말이지.. ?"));
                }
                Go();
            }
            else if (Swichs == 19)
            {
                K = 22;
                Btn.SetActive(true);
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(3.89f, 33.67f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }


        }
        if (K == 23)
        {
            if (Swichs == 0)
            {
                //Debug.Log("작동중");

                //if (Swichs == 0)
                //{
                Btn.SetActive(false);
                can.SetActive(true);
                can2.SetActive(false);
                Em.SetActive(false);
                text1.SetActive(false);
                textname1.SetActive(false);
                
                //Debug.Log("켜졌다" + can.activeInHierarchy);
                Endimage1.SetActive(true);
                playerc.rightBtn = false;
                playerc.leftBtn = false;

                if (iscaech == false)
                {
                    StartCoroutine(massage("' 나는 신전의 입구를 통해 원래 들어갔던 곳으로 다시 나왔다 '"));
                }
                Go();
                //}
            }
            else if (Swichs == 1)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 한참을 걷다 문뜩 뒤를 돌아보니 신전은 사라져 있었다 '"));
                }
                Go();
            }
            else if (Swichs == 2)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("'그렇게 나는 다시 집으로 돌아왔다 '"));
                }
                Go();
            }
            else if (Swichs == 3)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 이 유물이 나에게 무엇을 줄 지 그 누구도 모른다 '"));
                }
                Go();
            }
            else if (Swichs == 4)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 하지만 이미 얻었을지도 모른다 '"));
                }
                Go();
            }
            else if (Swichs == 5)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("' 나는 오늘도 탐험을 하기위해 떠날 것 이다 '"));
                }
                Go();
            }
            else if (Swichs == 6)
            {
                if (iscaech == false)
                {
                    StartCoroutine(massage("The End"));
                    StartCoroutine(potal.LodeScenes(potal.potalnumber));
                }
            }
        }
    }


    public void OnCricks()
    {
        if (can == true)
        {
            if (isbutten == false)
            {
                Swichs += 1;
                iscaech = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(0);
        if (coll.gameObject.tag == "Player" && K == -2)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            K = -1;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 0)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            K = 1;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 2)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            K = 3;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 4)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            K = 5;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 6)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            K = 7;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 8)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            K = 9;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 10)
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            K = 11;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 12)
        {
            K = 13;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 14)
        {
            K = 15;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 16)
        {
            K = 17;
            Swichs = 0;
            box.enabled = false;
        }
            if (coll.gameObject.tag == "Player" && K == 18)
            {
                K = 19;
            Swichs = 0;
            box.enabled = false;
            }
        if (coll.gameObject.tag == "Player" && K == 20)
        {
            K = 21;
            Swichs = 0;
            box.enabled = false;
        }
       if(coll.gameObject.tag == "Player" && K == 22)
        {
            K = 23;
            Swichs = 0;
            box.enabled = false;
        }
    }

    public void Sp()
    {
        textname.text = "스핑크스";
        textname.color = new Color32(255, 64, 75, 255);
        text.color = new Color32(255, 255, 255, 255);
    }
        public void SC()
        {
            textname.text = "의문의 여인";
            textname.color = new Color32(255, 64, 75, 255);
            text.color = new Color32(255, 255, 255, 255);
        }
        public void Go()
    {
        textname.text = "고오고";
        textname.color = new Color32(0, 255, 255, 255);
        text.color = new Color32(255, 255, 255, 255);
    }

    public IEnumerator massage(string T)
    {
        int a = 0;
        string wittext = "";
        isbutten = true;
        iscaech = true;
        playerc.rightBtn = false;
        playerc.leftBtn = false;
        playerc.at.SetBool("isRun", false);
        for (a = 0; a < T.Length; a++)
        {
            wittext += T[a];
            text.text = wittext;
            text2.text = wittext;
            yield return new WaitForSeconds(0.05f);
        }
        isbutten = false;
    }

    IEnumerator Down()
    {
        block.SetActive(false);
        yield return new WaitForSeconds(2);
        block.SetActive(true);
        cameracc.transform.position = new Vector3(-4.198f, 1.4915f, -10);
        Swichs = 15;
        yield return null;
    }

}
