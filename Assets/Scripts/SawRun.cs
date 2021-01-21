using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRun : MonoBehaviour
{
    public float speed;
    public Transform tf;
    public bool b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(tf.position.x < -8.15f)
        {
            b = false;
        }
        if (tf.position.x > 9.05f )
        {
            b = true;
        }
        if(b == false)
        {
            tf.Translate(Vector2.right * speed * Time.deltaTime);  
        }
        if(b == true)
        {
            tf.Translate(Vector2.left * speed * Time.deltaTime);
        }
            
        
    }
}
