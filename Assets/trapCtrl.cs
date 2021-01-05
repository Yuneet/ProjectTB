using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class trapCtrl : MonoBehaviour
    
{
    //public bool start;
    public birdCtrl birdCtrl;
    public float speed;
    // Start is called before the first frame update



    void Start()
    {        
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * 10 * Time.deltaTime);

        

        if(transform.position.x < -4.39f && birdCtrl.start == true)
        {
            transform.position = new Vector3(3.06f, 0.7f,-3f);
        }
        else if (birdCtrl.start == true)
        {
            
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

    }

}
