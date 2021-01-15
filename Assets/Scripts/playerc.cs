using System.Collections;
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
    //public bool Damage;

    /*GameObject scanObject;
    public GameManager manager;*/

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        at = GetComponent<Animator>();
        sfx = GetComponent<AudioSource>();
    }
    void Start()
    {
        sfx.volume = PlayerPrefs.GetFloat("sfx");
    }
    // Update is called once per frame
    void Update()
    {
        /*if (manager.isAction == false)
        {*/
            isJump = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);

            //input.GetKeyDown == 키를 한번 눌렸을때
            //input.GetKeyUp == 누른 키를 땟을때
            //input.GetKey == 키를 계속 누르고 있을때

            if (GetComponent<Rigidbody2D>().velocity.normalized.y > 0)
            {
                at.SetBool("isJump", true);
            }

            if (GetComponent<Rigidbody2D>().velocity.normalized.y < 0)
            {
                at.SetBool("isJump", false);
                at.SetBool("isFall", true);
            }

            if (GetComponent<Rigidbody2D>().velocity.normalized.y == 0)
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
            if(!at.GetBool("isJump"))
                at.SetBool("isRun", true);
                RunSound();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                //GetComponent<SpriteRenderer>().flipX = true;
                GetComponent<SpriteRenderer>().flipX = false;
                if(!at.GetBool("isJump"))    
                    at.SetBool("isRun", true);
                RunSound();
            }
            if (Input.GetKeyDown(KeyCode.Space) && isJump == true)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jump;
                at.SetBool("isRun", false);
                JumpSound();
                //manager.Action(scanObject);
            }

            if (leftBtn == true && rightBtn == false)
            {
                //Debug.Log("왼쪽왼쪽");
               /* if (Damage == false)
                {*/
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                    GetComponent<SpriteRenderer>().flipX = false;
                    if (!at.GetBool("isJump"))
                        at.SetBool("isRun", true);
                    RunSound();
                /*}
                else
                {
                    transform.Translate(Vector2.left * speed * 0);
                    at.SetBool("isRun", false);
                }*/
            }

            if (rightBtn == true && leftBtn == false)
            {
                //Debug.Log("오른쪽오른쪽");
                /*if (Damage == false)
                {*/
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                    GetComponent<SpriteRenderer>().flipX = true;
                     if (!at.GetBool("isJump"))
                        at.SetBool("isRun", true);
                         RunSound();
                /*}
                else
                {
                    transform.Translate(Vector2.right * speed * 0);
                    at.SetBool("isRun", false);
                }*/
            }
        //}
    }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Saw")
            {
                OnDamaged(collision.transform.position);
                istag = true;
            }
        }
        public void OnDamaged(Vector2 targetPos)
        {
            //Damage = true;
            gameObject.layer = 11;

            sprite.color = new Color(1, 1, 1, 0.4f);

            //dirc == 피격데미지를 입고 뒤로 밀려나는 범위
            int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
            rigid.AddForce(new Vector2(dirc, 1) * 5.5f, ForceMode2D.Impulse);
            Invoke("OffDamaged", 1.5f);
            DamagedSound();
        }

        public void OffDamaged()
        {
            //Damage = false;
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
        if (!at.GetBool("isJump"))
            at.SetBool("isRun", true);
    }

        public void leftOnPointerUp()
        {
            leftBtn = false;
        at.SetBool("isRun", false);
         /* if (!at.GetBool("isJump"))
            at.SetBool("isRun", true);*/
        StopSound();
        }

        public void rightOnPointerDown()
        {
            rightBtn = true;
        if (!at.GetBool("isJump"))
            at.SetBool("isRun", true);
    }

        public void rightOnPointerUp()
        {
            rightBtn = false;
        at.SetBool("isRun", false);
             /*if (!at.GetBool("isJump"))
            at.SetBool("isRun", true);*/
        StopSound();
        }

        public void jumps()
        {
            if (isJump == true /* && Damage == false*/)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jump;
                JumpSound();
                at.SetBool("isRun", false);
               // manager.Action(scanObject);
            }
            else if (isJump == false /*&& Damage == true*/)
            {
               //GetComponent<Rigidbody2D>().velocity = Vector2.up * jump * 0;
                StopSound();
            }
        }
    
}
