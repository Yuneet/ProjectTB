using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCtrl : MonoBehaviour
{

    public bool istrap;
    public bool istraptrg;
    public float time;

    //public Rigidbody2D rigidbody2D;
    public playerc playerctrl;
    public LayerMask layer;
    public Transform boxtransfrom;
    public float x;
    public float y;
    public float taget;


    // Start is called before the first frame update
    void Awake()
    {
        time = 3;
        //rigidbody2D = GetComponent<Rigidbody2D>();
        boxtransfrom = GetComponent<Transform>();
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        istrap = Physics2D.OverlapCircle(playerctrl.feetPos.position, playerctrl.checkRadius,layer);

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

        if (istraptrg == true && /*istrap == false &&*/ transform.position.y <= taget) //1.85
        {
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
            gameObject.transform.position = new Vector2(x, y);
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            istraptrg = false;
            time = 3; // time이 0이하로 되어있을거니 초기화시켜줌 
            
        }
        
    }



}
