﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgm;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = bgm;

        audioSource.volume = 1.0f;
        audioSource.loop = true;

        audioSource.playOnAwake = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
