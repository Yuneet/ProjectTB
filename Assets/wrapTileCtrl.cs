using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrapTileCtrl : MonoBehaviour
{
    public playerctrl playerctrl;
    public bool iswarp;
    public LayerMask layer;
    public float[] xy = new float[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iswarp = Physics2D.OverlapCircle(playerctrl.tf.position, playerctrl.checkRadius, layer);

        if (iswarp == true)
        {
            playerctrl.transform.position = new Vector3(xy[0],xy[1],xy[2]); // 12,12.54f,-2
            Debug.Log("다았다!");
        }
    }
}
