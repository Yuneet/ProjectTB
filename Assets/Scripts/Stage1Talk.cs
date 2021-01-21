
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Talk : MonoBehaviour
{
    public Text text;
    public Text name;
    public BoxCollider2D box;
    public GameObject gameObject1;
    public GameObject gameObject2;
    private bool iscaech;
    private bool isbutten;
    private float btnnumber;
    private string[] talk = { "테스트 임다~~~", "대사를 내놔라아아","떨어져."};
    private string[] names = {"{ 스핑크스 }","{ 고오고 }"};

    // Start is called before the first frame update
    void Awaek()
    {
        btnnumber = 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (btnnumber == 0) { 
            if (iscaech == false)
            {
                StartCoroutine(massage(names[0],talk[0],name.color = new Color32(255,73,73,255)));
            }
        }else if (btnnumber == 1)
        {
            if (iscaech == false)
            {
                StartCoroutine(massage(names[1], talk[1],name.color = new Color32(23,202,255,255)));
            }
        }else if (btnnumber == 2)
        {
            if (iscaech == false)
            {
                StartCoroutine(massage(names[0], talk[2], name.color = new Color32(255, 73, 73, 255)));
            }
        }else if (btnnumber == 3)
        {
            if (iscaech == false)
            {
                gameObject1.SetActive(false);
                StopCoroutine(Down());
                StartCoroutine(Down());
                btnnumber = 0;
            }
        }
    }

    public IEnumerator massage(string named,string T,Color32 color)
    {
        int a = 0;
        string wittext = "";
        isbutten = true;
        iscaech = true;
        name.text = named;
        for (a = 0; a < T.Length; a++)
        {

            wittext += T[a];
            text.text = wittext;
            yield return new WaitForSeconds(0.1f);

        }
        isbutten = false;
    }

    //255,73,73,255 스핑크스
    //23,202,255,255 고오고
    public void OnCrick()
    {
        if (isbutten == false)
        {
            btnnumber += 1;
            iscaech = false;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(0);
        if (coll.gameObject.tag == "Player")
        {
            //Debug.Log(1);
            /*if (box.enabled != false && !CheckUnder.isUnder)
            {
                //Debug.Log(2);
                StopCoroutine(HideBlock());
                StartCoroutine(HideBlock());
            }*/
            Debug.Log("다았다");
            box.enabled = false;
            gameObject1.SetActive(true);        
        }
    }

    IEnumerator Down()
    {
        gameObject2.SetActive(false);
        yield return new WaitForSeconds(2);
        gameObject2.SetActive(true);
        yield return null;
    }

}
