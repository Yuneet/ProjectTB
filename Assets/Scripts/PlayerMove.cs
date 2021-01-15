using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jump;

    public bool isjump;

    public Transform Feet;
    public float checkfeet;
    public LayerMask layer;

    Rigidbody2D rg;
    SpriteRenderer PlayerFilp;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        PlayerFilp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            PlayerFilp.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            PlayerFilp.flipX = true;
        }

        isjump = Physics2D.OverlapCircle(Feet.position, checkfeet, layer);
        Debug.Log(isjump);

        if (Input.GetKeyDown(KeyCode.Space) && isjump == true)
        { 
            rg.velocity = Vector2.up * jump;
        }
    }
       
}
