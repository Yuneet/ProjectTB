using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Sprites;

public class endingcreditsCtrl : MonoBehaviour
{
    public Text text;
    public Sprite[] sprite;
    private string[] massage = {"팀명 : MA - T","그래픽 팀장 이준","그래픽 부원 김도영","프로그래밍 팀장 김규빈","프로그래밍 팀원 안준수","프로그래밍 팀원 신건수","도움을 준 사람 김종상","총괄 대표 신건수","To be Continued"};
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
        //Debug.Log(massage[1]);
        StartCoroutine(Changes(spriteRenderer, sprite, text));
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 9)
        {
            StopCoroutine(Changes(spriteRenderer, sprite, text));
            StartCoroutine(potal.LodeScenes(potal.potalnumber));
            number++;
        }
    }

    public void OnClick()
    {
        StopCoroutine(Changes(spriteRenderer, sprite, text));
        StartCoroutine(potal.LodeScenes(potal.potalnumber));
    }

    public IEnumerator Changes(SpriteRenderer spriteRenderers, Sprite[] sprites, Text texts)
    {
        bool isShow = false;
        
        while (!isShow && text.color.a >= 0)
        {
            //Debug.Log(1);
            if (text.color.a >= 1)
            {
                isShow = true;
            }
            if (!isShow)
            {
                text.text = massage[number];
                spriteRenderer.sprite = sprite[number];
                text.color = new Color(0, 0, 0, text.color.a + 0.02f);              
                spriteRenderer.color = new Color(1, 1, 1, spriteRenderer.color.a + 0.02f);
            }
            yield return new WaitForSeconds(0.1f);
        }
        while (isShow && text.color.a >= 0)
        {
            //Debug.Log(2);
            text.color = new Color(0, 0, 0, text.color.a - 0.02f);
            spriteRenderer.color = new Color(1, 1, 1, spriteRenderer.color.a - 0.02f);
            yield return new WaitForSeconds(0.1f);
        }
        text.color = new Color(0, 0, 0, 0);
        spriteRenderer.color = new Color(1, 1, 1, 0);
        number ++;
        //Debug.Log("number : " + number);
        switch (number)
        {
            case 1:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 2:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 3:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 4:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 5:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 6:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 7:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 8:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            /*case 9:
                StartCoroutine(Changes(spriteRenderer, sprite, text));
                break;
            case 10:
                break;*/
            default :;
                break;
        }
    }
}