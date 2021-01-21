using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapTileCtrl : MonoBehaviour
{
    public playerc playerctrl;
    public bool iswarp;
    public LayerMask layer;
    public Vector3 targetPos = new Vector3(12, 12.54f, -2);
    public bool isflip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  

        //iswarp = Physics2D.OverlapCircle(playerctrl.feetPos.position, playerctrl.checkRadius, layer);

        /*if (iswarp == true)
        {
            playerctrl.transform.position = targetPos;
            Debug.Log("다았다!");
        }*/
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (isflip == true)
        {
            playerctrl.GetComponent<SpriteRenderer>().flipX = true;
            Debug.Log(4);
        }
        Debug.Log(0);
        if (coll.gameObject.tag == "Player")
        {
            //if (iswarp == true)
            //{
                playerctrl.transform.position = targetPos;
            //}            
        }
    }

}
