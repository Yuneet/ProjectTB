using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class potal : MonoBehaviour
{

    public Transform feetPos;
    public float checkRadius;
    public LayerMask layer;
    public bool isPortal = false;
    public Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        isPortal = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);
        if(isPortal == true)
        {
            SceneManager.LoadScene(2);
            
        }

    }
}
