using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class potal : MonoBehaviour
{

    public Transform feetPos;
    public float checkRadius;
    public LayerMask layer;
    public bool isPortal = false;
    public Rigidbody2D rigid;
    public int potalnumber;
    public cameracc maincamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        //SceneManager.LoadScene(1);
        StopCoroutine(LodeScenes());
        StartCoroutine(LodeScenes());
    }

    // Update is called once per frame
    void Update()
    {
        isPortal = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);
        if(isPortal == true)
        {
            //SceneManager.LoadScene(potalnumber);
            StopCoroutine(LodeScenes());
            StartCoroutine(LodeScenes());
            Debug.Log(1);
        }
    }

    IEnumerator LodeScenes()
    {
        Debug.Log("로딩화면 보여주기");
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(potalnumber);
    }


    /*void OnEnable()
    {
        SceneManager.sceneLoaded += OnsceneLoaded;
    }
    void OnsceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(1);
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnsceneLoaded;
    }*/
}
