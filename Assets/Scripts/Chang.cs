using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chang : MonoBehaviour
{
    public float speed;
    public float start;
    public float middle;
    public float end;

    public float timer = -0.1f;
    public float timerx;

    public bool check1;
    public bool check2;
    public bool check3;
    bool CanAttack = true;
    public void setCanAtk(bool b)
    {
        CanAttack = b;
    }
    void Start()
    {

    }


    void Update()
    {
        if (check1 && !check2 && !check3)
        {
            if (!CanAttack)
                CanAttack = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            if (CanAttack)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        if (transform.position.y > start && transform.position.y < middle && timer < 0 && check1 == false && check3 == false)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            check1 = true;
            timer += 0.4f;
        }
        if (transform.position.y > middle && transform.position.y < end && timer < 0 && check1 == true && check2 == false)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            check1 = false;
            check2 = true;
            timer += 0.07f;
        }
        if (transform.position.y > end && timer < 0 && check2 == true)
        {
            check2 = false;
            check3 = true;
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            timer += 0.001f;
        }
        if (transform.position.y > end)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.003f, 1);
        }
        if (transform.position.y > middle && transform.position.y < end && timer < 0 && check1 == true && check2 == false)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.003f, 1);
        }
        if (transform.position.y > start && transform.position.y < middle && timer < 0 && check1 == false && check3 == false)
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.003f, 1);
        }


            if (check1 == true && check2 == false && timer < 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (check1 == false && check2 == true && timer < 0)
        {
            transform.Translate(Vector2.up * speed * 2f * Time.deltaTime);
        }
        if (check1 == false && check2 == false && transform.position.y < end && transform.position.y > start && timer < 0)
        {
            transform.Translate(Vector3.down * speed * 2f * Time.deltaTime);
        }
        if (transform.position.y < start)
        {
            check3 = false;
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, 1);
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime * timerx;
        }
    }
}
