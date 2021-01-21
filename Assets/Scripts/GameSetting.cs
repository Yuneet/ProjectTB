using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public bool isbtn;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
            gameObject2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       //isbtn = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);
    }

    /*void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "btn")
        {
            StopCoroutine("Btn");
            StartCoroutine("Btn");
        }
    }*/
    public void OnCrick()
    {      
           //StartCoroutine("Btn");
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
        Debug.Log("클릭되었습니다");
    }

    public void OffCrick()
    {
        gameObject1.SetActive(true);
        gameObject2.SetActive(false);
    }

    /*IEnumerable Btn()
    {
        gameObject1.SetActive(false);
        yield return new WaitForSeconds(1);
        gameObject2.SetActive(true);
        Debug.Log("시작");
    }*/
}
