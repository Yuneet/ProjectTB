using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Sprites;

public class endingcreditsCtrl : MonoBehaviour
{
    public Text text;
    public Sprite[] sprite;
    public string[] massage = {"프로그래밍 팀장 김규빈","프로그래밍 부원 안준수"};
    public SpriteRenderer spriteRenderer;
    public int number;
    public float timer;
    private bool isca;
    public potal potal;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        timer = 0f;

        StartCoroutine(Changes(spriteRenderer, sprite, text));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        StopCoroutine(Changes(spriteRenderer, sprite, text));
        //setting.SetActive(false);
        //load.SetActive(true);
        StartCoroutine(potal.LodeScenes(potal.potalnumber));
    }

    public IEnumerator Changes(SpriteRenderer spriteRenderers, Sprite[] sprites, Text texts)
    {

        bool isShow = false;
        while (!isShow && text.color.a >= 0)
        {
            Debug.Log(1);
            if (text.color.a >= 1)
            {
                isShow = true;
            }
            if (!isShow)
            {
                text.color = new Color(0, 0, 0, text.color.a + 0.05f);
                //spriteRenderer.color = text.color;
                spriteRenderer.color = new Color(1, 1, 1, spriteRenderer.color.a + 0.05f);
            }
            yield return new WaitForSeconds(0.1f);
        }
        while (isShow && text.color.a >= 0)
        {
            Debug.Log(2);
            text.color = new Color(0, 0, 0, text.color.a - 0.05f);
            //spriteRenderer.color = text.color;
            spriteRenderer.color = new Color(1, 1, 1, spriteRenderer.color.a - 0.05f);
            yield return new WaitForSeconds(0.1f);
        }
        number++;
        switch (number)
        {
            case 1: StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 2:                 
                break;
            default :
                ; break;
        }
    }
}