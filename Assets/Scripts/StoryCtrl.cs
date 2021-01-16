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
    private string[] talk = { "세계에는 아직 밝혀지지 않은 이야기가 있다.", "그것은 바로 준수에 관한 이야기이다.", "바보다" };
    public int Scenesnumber;



    void Awaek()
    {
        SeenNumners = 0;
        //Image = gameObject1.GetComponent<Image>();
        //Image.GetComponent<Image>().sprite = sprite;
        
    }

    void Start()
    {
        //gameObject1.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                StopCoroutine(LodeScenes());
                StartCoroutine(LodeScenes());
            }
        }

        if (SeenNumners == 0)
        {
            gameObject1.SetActive(true);
            gameObject10.SetActive(false);
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
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
            text.text = talk[2];
        }
        else if (SeenNumners == 3)
        {
            gameObject3.SetActive(false);
            gameObject4.SetActive(true);
            text.text = "4";
        }
        else if (SeenNumners == 4)
        {
            gameObject4.SetActive(false);
            gameObject5.SetActive(true);
            text.text = "5";
        }
        else if (SeenNumners == 5)
        {
            gameObject5.SetActive(false);
            gameObject6.SetActive(true);
            text.text = "6";
        }
        else if (SeenNumners == 6)
        {
            gameObject6.SetActive(false);
            gameObject7.SetActive(true);
            text.text = "7";
        }
        else if (SeenNumners == 7)
        {
            gameObject7.SetActive(false);
            gameObject8.SetActive(true);
            text.text = "8";
        }
        else if (SeenNumners == 8)
        {
            gameObject8.SetActive(false);
            gameObject9.SetActive(true);
            text.text = "9";
        }
        else if (SeenNumners == 9)
        {
            gameObject9.SetActive(false);
            gameObject10.SetActive(true);
            text.text = "10";
        }else if (SeenNumners == 10)
        {
            SeenNumners = 0;
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
        
    }

    IEnumerator LodeScenes()
    {
        Debug.Log("로딩화면 보여주기");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(Scenesnumber);
    }
}
