using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jamp;
    public bool isJump = false;

    public Transform tf; //캐릭터 발의 위치
    public float checkRadius; // 발의 위치에서 체크할 크기
    public LayerMask layer; //바닥이 같은레이어인지 체크위해 레이어설정
    public Animator at;
    public Rigidbody2D rg;

    void Awake()
    {
         at = GetComponent<Animator>();
         rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rg.bodyType = RigidbodyType2D.Static;
        //rg.bodyType = RigidbodyType2D.Static;
        //Debug.Log(rg.bodyType);
        
        isJump = Physics2D.OverlapCircle(tf.position, checkRadius, layer);
        
        //input.getkeydown == 키를 한번 눌렀을때
        //input.getkeyup ==  누른 키를 뗏을 때
        //input.getkey == 키를 계속 누르고 있을 때
        
       


        if (GetComponent<Rigidbody2D>().velocity.normalized.y > 0)
        {
            at.SetBool("isJump",true);
        }
        
        else if (GetComponent<Rigidbody2D>().velocity.normalized.y < 0)
        {
            at.SetBool("isJump", false);
            at.SetBool("is Fall", true);
        }

        else if (GetComponent<Rigidbody2D>().velocity.normalized.y == 0)
        {
            at.SetBool("is Fall", false);
        }

        //Debug.Log("velocity : " + GetComponent<Rigidbody2D>().velocity.normalized);


        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            at.SetBool("isRun", false);
        }
        

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = false;
            at.SetBool("isRun",true);
        }else if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = true;
            at.SetBool("isRun", true);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isJump == true){
            //at.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jamp;
                //transform.Translate(Vector2.up * jamp * Time.deltaTime);
        }

       






    }
}
