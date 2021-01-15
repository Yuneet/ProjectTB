using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCtrl : MonoBehaviour
{
    ColCtrl CheckUnder = null;
    BoxCollider2D box =null;
    bool isRunning = false;
    public float timer = 1;
    /*public bool istrap;
    public bool istraptrg;
    public float time;

    public Rigidbody2D rigidbody2D;
    public playerc playerctrl;
    public LayerMask layer;
    public Transform boxtransfrom;
    public float x;
    public float y;
    public float taget;
    public GameObject tagetbox;*/

    // Start is called before the first frame update
    void Awake()
    {
        //rigidbody2D = GetComponent<Rigidbody2D>();
        //boxtransfrom = GetComponent<Transform>();
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        CheckUnder = GetComponent<ColCtrl>();
        box = GetComponent<BoxCollider2D>();

    }

    void Start()
    {

    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log(0);
        if (coll.gameObject.tag == "Player")
        {
            //Debug.Log(1);
            if (box.enabled != false && !CheckUnder.isUnder)
            {
               //Debug.Log(2);
                StopCoroutine(HideBlock());
                StartCoroutine(HideBlock());
            }
        }
    }
    IEnumerator HideBlock()
    {
        isRunning = true;
        //yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(timer);
        box.enabled = false;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        //yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        box.enabled = true;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        isRunning = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(box.enabled == CheckUnder.isUnder && !isRunning)
        {
            box.enabled = !CheckUnder.isUnder;
        }
        /*
        Debug.Log(this.name);
        //Debug.Log(Time.time);
     
            istrap = Physics2D.OverlapCircle(playerctrl.feetPos.position, playerctrl.checkRadius, layer);
        
        if (istrap == true && time < 0) // 트랩에 걸려있고 time이 0이라면 떨어지게
        {
            GetComponent<SpriteRenderer>().color = new Color32(255,255,255,0);
            Debug.Log("트랩에 걸렸습니다.");
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            istraptrg = true;
        }

        else if (istrap == true && time > 0)
        {
            time -= Time.deltaTime * 1.5f; // time 변수가 0이 아니고 트랩에 걸려있으면 프레임 * 1.5초 만큼 time을 빼줌
        }

        if (istraptrg == true && /*istrap == false && transform.position.y <= taget) //1.85
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            gameObject.transform.position = new Vector2(x, y);
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            istraptrg = false;
            time = 3; // time이 0이하로 되어있을거니 초기화시켜줌 
            
        }
        */
    }



}
