using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameout : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape) && gameObject1.activeSelf == true)
            {
                gameObject1.SetActive(false);
                gameObject2.SetActive(true);
            }
        }
    }

    public void onyes()
    {
        Application.Quit();
    }

    public void onno()
    {
        gameObject1.SetActive(true);
        gameObject2.SetActive(false);
    }
}
