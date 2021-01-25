using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;
    public Text text2;
    float sce;
    int Min;
    int besttime;

    public float a;
    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetFloat("text2",0);  
    }

    // Update is called once per frame
    void Update()
    {
        Timers();

       maxtimers();
   
    }

    public void Timers()
    {
        sce += Time.deltaTime;
        text.text = string.Format("{0:D2} : {1:D2}", Min, (int)sce);
        // text.text = Time.time.ToString("N2");
        if ((int)sce > 59)
        {
            sce = 0;
            Min++;
        }
       
       PlayerPrefs.SetFloat("text2",0);


    }

    public void maxtimers()
    {
        /*sce += Time.deltaTime;
        text2.text = string.Format("{0:D2} : {1:D2}", Min, (int)sce);
        // text.text = Time.time.ToString("N2");
        if ((int)sce > 59)
        {
            sce = 0;
            Min++;
        }
        PlayerPrefs.GetInt("text",besttime);*/
    }
}

