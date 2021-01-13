using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    public int talkIndex;
    public bool isAction;
    public GameObject scanObject;
    public GameObject talkPanel;
    public Text UITalkText;
    public Image portraitImg;
    public void Action(GameObject scanObj)
    {
        if(isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            scanObject = scanObj;

            ObjData objData = scanObject.GetComponent<ObjData>();
            Talk(objData.id, objData.isNPC);
        }
        talkPanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if (isNPC)
        {
            UITalkText.text = talkData.Split(':')[0];
            portraitImg.sprite = talkManager.GetPortrait(id, int.Parse(talkData.Split(':')[1]));
            portraitImg.color = new Color(1, 1, 1, 1);
        }
        else
        {
            UITalkText.text = talkData;
            portraitImg.color = new Color(1, 1, 1, 0);
        }
        isAction = true;
        talkIndex++;
    }
    

}
