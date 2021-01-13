﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


enum state
{
    main = 1,
    stage1 = 2,
}

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Click()
    {
        SceneManager.LoadScene(1);
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnsceneLoaded;
    }
    void OnsceneLoaded(Scene scene, LoadSceneMode mode)
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
