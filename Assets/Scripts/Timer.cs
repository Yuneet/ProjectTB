using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;
    float sce;
    int Min;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sce += Time.deltaTime;
        text.text = string.Format("{0:D2} : {1:D2}", Min, (int)sce);
       // text.text = Time.time.ToString("N2");
        if((int)sce > 59)
        { 
            sce = 0;
            Min++;
        }
      
    }
}
