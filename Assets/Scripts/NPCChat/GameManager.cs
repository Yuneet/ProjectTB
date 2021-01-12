using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;

    public void Action(GameObject scanObj)
    {
        if(isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            talkPanel.SetActive(true);
            scanObject = scanObj;
            talkText.text = "난 '" + scanObject.name + "' 라고 해";
        }
        talkPanel.SetActive(isAction);

    }
}
