using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource btnsouce;
    // Start is called before the first frame update
    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }

    public void SetButtonVolume(float volume)
    {
        btnsouce.volume = volume;
    }

    public void onbtn()
    {
        PlayerPrefs.SetFloat("bgm", musicsource.volume);
        PlayerPrefs.SetFloat("sfx", btnsouce.volume);
    }

   
    // Update is called once per frame
    void Update()
    {
        Debug.Log(musicsource.volume);
        //0.4249481
    }
}
