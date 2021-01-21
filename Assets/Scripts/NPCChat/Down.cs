using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public GameObject P;
    public GameObject block;
    public potal potal;
    private bool isstrat;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P.transform.position.x >= 1.25f)
        {
            block.SetActive(false);
        }

        if(P.transform.position.y <= -17.7f)
        {
            if (isstrat == false) 
            {
                StartCoroutine(potal.LodeScenes(potal.potalnumber));
                isstrat = true;
            }
        }
    }
}
