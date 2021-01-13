using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnsceneLoaded;  
    }

    void OnsceneLoaded(Scene scene,LoadSceneMode mode)
    {
        //Debug.Log("OnSceneLoaded:" + scene.name);
        //Debug.Log(mode);
        Debug.Log(1);
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnsceneLoaded;
    }
}
