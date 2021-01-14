using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    private float SeenNumners;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public GameObject gameObject7;
    public GameObject gameObject8;
    public GameObject gameObject9;
    public GameObject gameObject10;



    void Awaek()
    {
        SeenNumners = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (SeenNumners == 0)
        {
            gameObject1.SetActive(true);
        }else if (SeenNumners == 1)
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
        }else if (SeenNumners == 2)
        {
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
        }
        
    }

    public void OnCrick()
    {
        SeenNumners += 1;
    }
}
