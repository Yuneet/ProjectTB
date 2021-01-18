using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    private float SeenNumners;
    
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameObject8;
    public GameObject gameObject9;
    public GameObject gameObject10;
    public Text text;
    private bool iscaech;
    private bool isbutten;
    private string[] talk = { "고오고는 세계에서 알아주는 팀중 하나였다.", "그들은 갖가지 위험한 지대를 다니며 유물을 발굴하고 다녔다.", "그들은 탐험을 무척이나 즐겼고 언제나 함께 탐험을 다녔다.", "하지만 몇년 전 탐험 도중 큰 피해를 입고, 자신의 소중한 팀원들을 잃었다.", "그는 그로인해 큰 트라우마가 생겨, 이 일을 접게 되었다.", "그렇게 몇년이 지났을까, 고오고에게 편지 한통이 도착했다.", "안녕하세요. 이 편지를 보시는 분이 바로 '고오고'님이 되시겠군요." , "오래전 아직 밝혀지지 않은 유물이 존재하기에 그것을 고오고님이", "꼭 발견 해주셨으면 좋겠다는 마음으로 편지를 보내봅니다." , "그 유물은 특수한 능력을 가지고 있다고 전해집니다.", "기다리고 있겠습니다." , "고오고는 이 편지를 읽자마자 구겨 휴지통에 집어넣는다." , "이미 즐거움이였던 탐험은 자신에게 큰 트라우마가 된 것이다." 
    ,"그렇게 몇일이 지났을까, 고오고는 그 편지의 내용이 머리에서 아른거려","다시 그 편지를 읽고 결심을 내린다, 마지막으로 도전을 해보자는 생각으로","그 이집트로 향하기로.."};
    public int Scenesnumber;
    public AudioSource audioSource;
    AudioCtrl audioCtrl;
    public potal potal;
    private float setstrat;


    void Awaek()
    {
        //SeenNumners = 0;
        //Image = gameObject1.GetComponent<Image>();
        //Image.GetComponent<Image>().sprite = sprite;
        
    }

    void Start()
    {
        //gameObject1.GetComponent<SpriteRenderer>().sprite = sprite;
        SeenNumners = 0;
        audioSource.volume = PlayerPrefs.GetFloat("bgm", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Application.platform == RuntimePlatform.Android)
        //{
            if (Input.GetKey(KeyCode.Escape))
            {
                //StopCoroutine(potal.LodeScenes(potal.potalnumber2));
                StartCoroutine(potal.LodeScenes(potal.potalnumber2));
            }
        //}

        if (SeenNumners == 0)
        {
            gameObject1.SetActive(true);
            //text.text = talk[0];
            if (iscaech == false) {
                StartCoroutine(cat(talk[0]));
            }
        }else if (SeenNumners == 1)
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
            //text.text = talk[1];
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[1]));
            }
        }
        else if (SeenNumners == 2)
        {
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[2]));
            }
        }else if (SeenNumners == 3)
        {
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[3]));
            }
        }else if (SeenNumners == 4)
        {
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[4]));
            }
        }else if (SeenNumners == 5)
        {
            gameObject3.SetActive(false);
            gameObject4.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[5]));
            }
        }else if (SeenNumners == 6)
        {
            gameObject4.SetActive(false);
            gameObject5.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[6]));
            }
        }else if (SeenNumners == 7)
        {
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[7]));
            }
        }else if (SeenNumners == 8)
        {
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[8]));
            }
        }else if (SeenNumners == 9)
        {
            gameObject5.SetActive(false);
            gameObject6.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[9]));
            }
        }else if (SeenNumners == 10)
        {
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[10]));
            }
        }else if (SeenNumners == 11)
        {
            gameObject6.SetActive(false);
            gameObject7.SetActive(true);
        }else if (SeenNumners == 12)
        {
            gameObject7.SetActive(false);
            gameObject8.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[11]));
            }
        }else if (SeenNumners == 13)
        {
            gameObject8.SetActive(false);
            gameObject10.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[12]));
            }
        }else if (SeenNumners == 14)
        {
            gameObject10.SetActive(false);
            gameObject5.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[13]));
            }
        }else if (SeenNumners == 15)
        {
            gameObject5.SetActive(false);
            gameObject10.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[14]));
            }
        }else if (SeenNumners == 16)
        {
            gameObject10.SetActive(false);
            gameObject9.SetActive(true);
            if (iscaech == false)
            {
                StartCoroutine(cat(talk[15]));
            }
        }

    }

    public IEnumerator cat(string ct)
    {     
            int a = 0;
            string wittext = "";
            isbutten = true;
            iscaech = true;
            for (a = 0; a < ct.Length; a++)
            {

                wittext += ct[a];
                text.text = wittext;
                yield return new WaitForSeconds(0.1f);

            }
            isbutten = false;
             
    }

    public void OnCrick()
    {
        if (isbutten == false) {
            SeenNumners += 1;
            iscaech = false;
        }

        if(SeenNumners == 17)
        {
            setstrat = PlayerPrefs.GetFloat("setstart", 0);
            if (setstrat == 0) {
                PlayerPrefs.SetFloat("setstart", 1);                
                StartCoroutine(potal.LodeScenes(potal.potalnumber));
            }else if (setstrat == 1)
            {               
                StartCoroutine(potal.LodeScenes(potal.potalnumber2));
            }

        }
        
    }

    /*IEnumerator LodeScenes()
    {
        Debug.Log("로딩화면 보여주기");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(Scenesnumber);
    }*/
}
