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

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (number == 0)
        {
            StartCoroutine(Changes(spriteRenderer, sprite, text));
        }else if(number == 1)
        {
            StartCoroutine(Changes(spriteRenderer, sprite, text));
        }

        /*if (isca == true)
        {
            timer += 0.001f;
            text.color = new Color(1, 1, 1, 0 + timer);
            spriteRenderer.color = new Color(1, 1, 1, 0 + timer);
        }
        else if(isca == false)
        {
            timer2 += 0.001f;
            text.color = new Color(1, 1, 1, 1 - timer2);
            spriteRenderer.color = new Color(1, 1, 1, 1 - timer2);
        }*/
    }

    /*public IEnumerator Changes(SpriteRenderer spriteRenderers, Sprite[] sprites, Text texts)
    {
        isca = true;
        timer2 = 0;
        yield return new WaitForSeconds(4f);
        timer = 0;
        isca = false;     
        yield return new WaitForSeconds(4f);
        number += 1;
    }*/

    public IEnumerator Changes(SpriteRenderer spriteRenderers, Sprite[] sprites, Text texts)
    {


        timer += 0.001f;
        Debug.Log(timer);
        while (timer < 1f)
        {
                text.color = new Color(1, 1, 1, 0 + timer);
                spriteRenderer.sprite = sprites[number];
                text.text = massage[number];
                spriteRenderer.color = new Color(1, 1, 1, 0 + timer);
                yield return new WaitForSeconds(0.1f);           
        }

        //yield return new WaitForSeconds(0.1f);

        if (timer >= 2f)
        {
             timer = 0;
             number += 1;
             Debug.Log("끝났다");
        }
        yield return null;
    }
}