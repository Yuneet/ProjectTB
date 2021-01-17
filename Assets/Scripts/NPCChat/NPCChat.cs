using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCChat : MonoBehaviour
{
    // Start is called before the first frame update
    public int Swichs = 0;
    public bool Check;
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
    //public Canvas Can;
    public GameObject can;
    public Text text;
    public Text textname;
    public int K = 0;
    public GameObject P;
    public BoxCollider2D box;
    public GameObject Npc;

    public GameObject Btn;
    public GameObject Btn2;
    public GameObject Btn3;

    void Awaek()
    {
        Swichs = 0;
        


    }

    void Start()
    {
        P = GetComponent<GameObject>();
        can.SetActive(false);
        gameObject1.SetActive(false);
        gameObject11.SetActive(false);
        gameObject2.SetActive(false);
        gameObject3.SetActive(false);
        gameObject33.SetActive(false);
        gameObject4.SetActive(false);
        gameObject5.SetActive(false);
        gameObject6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnCricks();
        }

        if (K == 3)
        {
            if (Swichs == 0)
            {
                can.SetActive(true);
                gameObject11.SetActive(true);
                text.text = "벌써 빛이 보이는구나 그런데 유물은 어디있지 ?";
                Go();
            }
        }

        // 두번째 스테이지 도착
        if (K == 12)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                Btn2.SetActive(false);
                Btn3.SetActive(false);
                can.SetActive(true);
                gameObject1.SetActive(true);
                text.text = "너 근데, 여기 오게 된 이유가 뭐야?";
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                text.text = "...";
                Go();
            }
            if (Swichs == 2)
            {
                gameObject11.SetActive(false);
                gameObject4.SetActive(true);
                text.text = "누군가가 여길 알려줬나?, 편지로? ㅎㅎㅎ";
                Sp();
            }
            else if (Swichs == 3)
            {
                text.text = "그게 너였구나?";
                Go();
            }
            if (Swichs == 4)
            {
                text.text = "아니~?, 난 모르겠는걸?";
                Sp();
            }
            else if (Swichs == 5)
            {
                text.text = "어쨋든 난 그 유물을 꼭 찾아야겠어, 어서 길을 알려줘";
                Go();
            }
            if (Swichs == 6)
            {
                gameObject4.SetActive(false);
                gameObject6.SetActive(true);
                text.text = "너가 그 유물을 찾던 난 관심없어";
                Sp();
            }
            if (Swichs == 7)
            {
                gameObject6.SetActive(false);
                gameObject3.SetActive(true);
                text.text = "내가 너무 심심해서 말이지, 얼른 이동해주면 안될까?";
                Sp();
            }
            else if (Swichs == 8)
            {
                text.text = "아무래도 그럴 참이였다, 너무 오래있으면 짜증날 것 같아서 말이지";
                Go();
            }
            else if (Swichs == 9)
            {
                gameObject3.SetActive(false);
                gameObject2.SetActive(true);
                text.text = "그거 지금 나보고 하는 소리야?";
                Sp();
            }
            else if (Swichs == 10)
            {
                Btn.SetActive(true);
                Btn2.SetActive(true);
                Btn3.SetActive(true);
                can.SetActive(false);
                gameObject2.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-20.18f, -3.96f, 0);
                box.enabled = true;
                K = 13;
            }
        }

        // 두번째 스테이지 첫번째 포탈 도착
        if (K == 14)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                Btn2.SetActive(false);
                Btn3.SetActive(false);
                can.SetActive(true);
                gameObject1.SetActive(true);
                text.text = "그런데, 넌 유물을 얻어서 뭘 하는데 쓰려고 하는거야 ?";
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                text.text = "그것까진 너가 알 것 없겠군";
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject11.SetActive(false);
                gameObject5.SetActive(true);
                text.text = "으 진짜 짜증나는 타입이네";
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject5.SetActive(false);
                gameObject6.SetActive(true);
                text.text = "너 여자친구 없지 ?";
                Sp();
            }
            else if (Swichs == 4)
            {
                text.text = "...";
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject6.SetActive(false);
                gameObject3.SetActive(true);
                text.text = "푸하핫, 장난이야 장난";
                Sp();
            }
            else if (Swichs == 6)
            {
                text.text = "유물은 사용자에게 반드시 무언가 하나를 안겨줘";
                Sp();
            }
            else if (Swichs == 7)
            {
                text.text = "돈이면 돈, 명예면 명예...";
                Sp();
            }
            else if (Swichs == 8)
            {
                text.text = "너무 큰 욕심만 아니면 너에게 곧 일어나게 될거야";
                Sp();
            }
            else if (Swichs == 8)
            {
                gameObject3.SetActive(false);
                text.text = "'팀원들을 다시 만날수도 .. 있는건가...";
                Go();
            }
            else if (Swichs == 9)
            {
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-29.35f, 1.24f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                K = 15;
            }
        }

        // 두번째 스테이지 포탈 이동 후
        if (K == 16)
        {
            if (Swichs == 0)
            {
                gameObject3.SetActive(false);
                Btn.SetActive(false);
                Btn2.SetActive(false);
                Btn3.SetActive(false);
                can.SetActive(true);
                text.text = "이정도 지대면 충분히 빠른 시일내에 이동이 가능하겠군";
                Go();
            }
            else if (Swichs == 1)
            {
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-17.59f, 35.82f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
                K = 17;
            }
        }

        // 두번째 스테이지 두번째 포탈 도착
        if (K == 18)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                Btn2.SetActive(false);
                Btn3.SetActive(false);
                can.SetActive(true);
                gameObject1.SetActive(true);
                text.text = "너 이런곳에 와보는거 한 두번이 아니구나?";
                Sp();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                text.text = "난 유물이 있다면 어디든지 탐험을 했지, 그랬었지..";
                Go();
            }
            else if (Swichs == 2)
            {
                gameObject1.SetActive(true);
                gameObject11.SetActive(false);
                text.text = "그랬었지..?, 그게 무슨 말이야?";
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject1.SetActive(false);
                gameObject11.SetActive(true);
                text.text = "아무것도 아니다, 그래서 난 어디쯤 까지 온 것이지?";
                Go();
            }
            else if (Swichs == 4)
            {
                gameObject33.SetActive(true);
                gameObject11.SetActive(false);
                text.text = "너무 서두르는 것 아니야?";
                Sp();
            }
            else if (Swichs == 5)
            {
                gameObject4.SetActive(true);
                gameObject33.SetActive(false);
                text.text = "내가 그렇게 쉽게 줄 것 같아?";
                Sp();
            }
            else if (Swichs == 6)
            {
                text.text = "너가 준다는 말인가?";
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject4.SetActive(false);
                gameObject2.SetActive(true);
                text.text = "아..아니?, 그게 무슨 말이야? 내가 언제 그랬다고 !";
                Sp();
            }
            else if (Swichs == 8)
            {
                text.text = "바보같은 놈, 표정에 티 다난다";
                Go();
            }
            else if (Swichs == 9)
            {
                gameObject2.SetActive(false);
                gameObject5.SetActive(true);
                text.text = "너가 한번 더 떨어져봐야 정신을 차리겠구나 ^^?";
                Sp();
            }
            else if (Swichs == 10)
            {
                text.text = "그런데 너는 어째서 이곳에 있는거지 ?";
                Go();
            }
            else if (Swichs == 11)
            {
                gameObject5.SetActive(false);
                text.text = "' 못들은 척 하더니, 어디론가 가버렸다 '";
                Go();
            }
            else if (Swichs == 12)
            {
                text.text = "...?";
                Go();
            }
            else if (Swichs == 13)
            {
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(-100f, 100f, 0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
                K = 19;
            }
        }

            if (K == 9)
        {
            if (Swichs == 0)
            {
                Btn.SetActive(false);
                Btn2.SetActive(false);
                Btn3.SetActive(false);
                can.SetActive(true);
                gameObject11.SetActive(true);
                text.text = "벌써 빛이 보이는구나 그런데 유물은 어디있지 ?";
                Go();
            }
            else if (Swichs == 1)
            {
                gameObject11.SetActive(false);
                gameObject3.SetActive(true);
                text.text = "왜이리 성급하냐구~ 난 아직 심심한데";
                Sp();
            }
            else if (Swichs == 2)
            {
                gameObject777.SetActive(true);
                gameObject3.SetActive(false);
                text.text = "' 자신이 쓰고있던 왕관을 건넨다 '";
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject777.SetActive(false);
                gameObject77.SetActive(true);
                text.text = "자 너가 그렇게 찾아 해매던 유물이다 !";
                Sp();
            }
            else if (Swichs == 4)
            {
                gameObject77.SetActive(true);
                gameObject777.SetActive(false);
                text.text = "...";
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject77.SetActive(false);
                gameObject7.SetActive(true);
                text.text = "난 이제 원하던 것을 얻은 것 같아서 말이야";
                Sp();
            }
            else if (Swichs == 6)
            {
                gameObject7.SetActive(false);
                gameObject777.SetActive(true);
                text.text = "그게 무슨 말이지 ?";
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject7.SetActive(true);
                gameObject777.SetActive(false);
                text.text = "난 말이야, 수천년동안 이곳에 갇혀있었어";
                Sp();
            }
            else if (Swichs == 8)
            {
                gameObject77.SetActive(true);
                gameObject7.SetActive(false);
                text.text = "이 신전을 지키기 위해서 말이지";
                Sp();
            }
            else if (Swichs == 9)
            {
                text.text = "혹시나 그 편지를 보낸건 너인가 ?";
                Go();
            }
            else if (Swichs == 10)
            {
                text.text = "심심했을 뿐이야, 오랜시간 그 누구도 보지 못했거든";
                Sp();
            }
            else if (Swichs == 11)
            {
                gameObject777.SetActive(true);
                gameObject77.SetActive(false);
                text.text = "그런가, 많은 탐험가들이 이곳을 오지 않았어 ?";
                Go();
            }
            else if (Swichs == 12)
            {
                gameObject77.SetActive(true);
                gameObject777.SetActive(false);
                text.text = "옛날에는 그랬지, 이젠 그 누구도 찾아오지 않아";
                Sp();
            }
            else if (Swichs == 13)
            {
                text.text = "'그녀는 단지 사람의 손길이 그리웠던 것 인걸까..'";
                Go();
            }
            else if (Swichs == 14)
            {
                text.text = "장난이 심했다면 사과할게, 이제 이 곳을 나가봐도 좋아";
                Sp();
            }
            else if (Swichs == 15)
            {
                text.text = "너는 어떻게 할 셈이야? 이곳을 나가지 않고";
                Go();
            }
            else if (Swichs == 16)
            {
                text.text = "그동안 즐거웠어, 나에겐 돌아갈 곳이 없거든";
                Sp();
            }
            else if (Swichs == 17)
            {
                gameObject77.SetActive(false);
                text.text = "' 그 말을 뒤로 그녀는 모습을 감췃다 '";
                Go();
            }
            else if (Swichs == 18)
            {
                text.text = "돌아갈 곳이 없다니, 그게 무슨 말이지.. ?";
                Go();
            }
            else if (Swichs == 19)
            {
                can.SetActive(false);
                Swichs = 0;
                Npc.transform.position = new Vector3(3.89f,33.67f,0);
                box.enabled = true;
                GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
            }
        }

    }

    public void OnCricks()
    {
        Swichs += 1;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(0);
        if (coll.gameObject.tag == "Player" && K == 0)
        {
            K = 12;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 11)
        {
            K = 12;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 13)
        {
            K = 14;
            Swichs = 0;
            box.enabled = false;
        }
        if (coll.gameObject.tag == "Player" && K == 15)
        {
            K = 16;
            Swichs = 0;
            box.enabled = false;
        }
            if (coll.gameObject.tag == "Player" && K == 17)
            {
                K = 18;
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
    public void Go()
    {
        textname.text = "고오고";
        textname.color = new Color32(0, 255, 255, 255);
        text.color = new Color32(255, 255, 255, 255);
    }

}
