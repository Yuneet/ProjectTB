using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCh : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public GameObject P;
    public bool istrue;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        istrue = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);
    }

    // Update is called once per frame
    void Update()
    {
        if (P.transform.position.y > 55)
        {
            if (istrue == true)
            {
                audioSource.clip = audioClips[0];
                audioSource.Play();
            }
        }
        else if (P.transform.position.y > 131)
        {
            if (istrue == true)
            {
                audioSource.clip = audioClips[1];
                audioSource.Play();
            }
        }
        else if (P.transform.position.y > 220)
        {
            if (istrue == true)
            {
                audioSource.clip = audioClips[2];
                audioSource.Play();
            }
        }
    }
}
