using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;
    public Sprite[] portraitArr;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        //대사 생성 
        talkData.Add(1000, new string[] { "당신도 여기가 어딘지 알고 온겁니까?:1", "그건 내 알바가 아니지\n유물이 있다는 소식에 왔다네:0", "아무튼 전 포기할테니 알아서 가든 말든 하세요:1" });

        //초상화 생성
        portraitData.Add(1000 + 0, portraitArr[0]); //0번 인덱스에 저장된 초상화를 id = 1000과 mapping
        portraitData.Add(1000 + 1, portraitArr[1]); //1번 인덱스에 저장된 초상화를 id = 1001과 mapping
    }

    public string GetTalk(int id, int talkIndex) //Object의 id , string배열의 index
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex]; //해당 아이디의 해당
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        Debug.Log(id + portraitIndex);
        //id는 NPC넘버 , portraitIndex : 표정번호(?)
        return portraitData[id + portraitIndex];
    }
}
