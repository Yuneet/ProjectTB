using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public GameObject P;
    public GameObject block;
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
    }
}
