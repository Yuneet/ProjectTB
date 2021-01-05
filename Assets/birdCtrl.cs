using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg;
    public float speed;
    public float points;
    Collision2D collision2D;
    public Text text;
    public bool start;
    public GameObject button;
    public trapCtrl trapCtrl1;
    public trapCtrl trapCtrl2;
  
    //public double[] a;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        points = 0;
        //Tap();
    }


    public void buttonck()
    {
        trapCtrl1.transform.position = new Vector3(3.06f, 0.7f, -6);
        trapCtrl2.transform.position = new Vector3(-2.24f, 0.7f, -6);
        transform.position = new Vector3(0, -2.51f, -3);
        points = 0;
        Time.timeScale = 1;
        button.SetActive(false);
        start = true;
    }

    public void Tap()
    {
        rg.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + points;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            Debug.Log(collision.gameObject.name);
            Time.timeScale = 0;
            start = false;
            button.SetActive(true);
        }
    }


    void OnTriggerExit2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag == "score")
        {
            Debug.Log(GameObject.Find("Text").name);
            points = points + 1;
       
            //text.text = "Score : " + points;
            
        }
    }
}
