using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCChat : MonoBehaviour
{
    // Start is called before the first frame update
    private float Swichs;
    public bool Check;
    public GameObject gameObject1;
    public GameObject gameObject2;
    //public Canvas Can;
    public GameObject can;
    public Text text;
    public Text textname;
    public float K;
    public GameObject P;

    void Awaek()
    {
        Swichs = 0;
        //Can = GetComponent<Canvas>();
        
    }

    void Start()
    {
        P = GetComponent<GameObject>();
        can.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Swichs);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnCricks();
        }

        if (P.transform.position.x >= 8 && P.transform.position.x <= 9)
        {
            K = 1;
        }
            if (K == 1)
        {
            if (Swichs == 0)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "벌써 빛이 보이는구나 그런데 유물은 어디있지 ?";
                Go();
            }
            else if (Swichs == 1)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "왜이리 성급하냐구~ 난 아직 심심한데";
                Sp();
            }
            else if (Swichs == 2)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "' 자신이 쓰고있던 왕관을 건넨다 '";
                Sp();
            }
            else if (Swichs == 3)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "자 너가 그렇게 찾아 해매던 유물이다 !";
                Sp();
            }
            else if (Swichs == 4)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "...";
                Go();
            }
            else if (Swichs == 5)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "난 이제 원하던 것을 얻은 것 같아서 말이야";
                Sp();
            }
            else if (Swichs == 6)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "그게 무슨 말이지 ?";
                Go();
            }
            else if (Swichs == 7)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "난 말이야, 수천년동안 이곳에 갇혀있었어";
                Sp();
            }
            else if (Swichs == 8)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "이 신전을 지키기 위해서 말이지";
                Sp();
            }
            else if (Swichs == 9)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "혹시나 그 편지를 보낸건 너인가 ?";
                Go();
            }
            else if (Swichs == 10)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "심심했을 뿐이야, 오랜시간 그 누구도 보지 못했거든";
                Sp();
            }
            else if (Swichs == 11)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "그런가, 많은 탐험가들이 이곳을 오지 않았어 ?";
                Go();
            }
            else if (Swichs == 12)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "옛날에는 그랬지, 이젠 그 누구도 찾아오지 않아";
                Sp();
            }
            else if (Swichs == 13)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "'그녀는 단지 사람의 손길이 그리웠던 것 인걸까..'";
                Go();
            }
            else if (Swichs == 14)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "장난이 심했다면 사과할게, 이제 이 곳을 나가봐도 좋아";
                Sp();
            }
            else if (Swichs == 15)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "너는 어떻게 할 셈이야? 이곳을 나가지 않고";
                Go();
            }
            else if (Swichs == 16)
            {
                gameObject1.SetActive(true);
                gameObject2.SetActive(false);
                text.text = "그동안 즐거웠어, 나에겐 돌아갈 곳이 없거든";
                Sp();
            }
            else if (Swichs == 17)
            {
                gameObject1.SetActive(false);
                gameObject2.SetActive(true);
                text.text = "' 그 말을 뒤로 그녀는 모습을 감췃다 '";
                Go();
            }
            else if (Swichs == 18)
            {
                gameObject1.SetActive(false);
                gameObject2.SetActive(true);
                text.text = "돌아갈 곳이 없다니, 그게 무슨 말이지.. ?";
                Go();
            }
            else if (Swichs == 19)
            {
                can.SetActive(false);
                Swichs = 0;
            }
        }

    }

    public void OnCricks()
    {
        Swichs += 1;
        Debug.Log("나 눌러졋어");
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
