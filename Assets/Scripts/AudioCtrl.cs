using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioCtrl : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource btnsouce;
    public AudioSource MainBgm;
    public AudioSource Startsfx;
    public Slider slider;
    public Slider slider2;
    // Start is called before the first frame update

    void Start()
    {

        PlayerPrefs.GetFloat("bgm", musicsource.volume);
        PlayerPrefs.GetFloat("sfx", btnsouce.volume);
        PlayerPrefs.GetFloat("slider", slider.value);
        PlayerPrefs.GetFloat("slider2", slider2.value);
    }

    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
        musicsource.volume = slider.value;
    }

    public void SetButtonVolume(float volume)
    {
        btnsouce.volume = volume;
        btnsouce.volume = slider2.value;
    }

    public void onbtn()
    {
        PlayerPrefs.SetFloat("bgm", musicsource.volume);
        PlayerPrefs.SetFloat("slider", slider.value);

        PlayerPrefs.SetFloat("sfx", btnsouce.volume);
        PlayerPrefs.SetFloat("slider2", slider2.value);
    }
    public void StartBtn()
    {
        Startsfx.Play();
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetFloat("sfx", 1.0f));
        //0.764848
    }
}
