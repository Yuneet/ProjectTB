using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_Player;

    /* void Awake()
    {
      스타트 이전에 실행되는 함수 
    }*/


    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(m_Player.transform.position.x, m_Player.transform.position.y,-10);
    }
}
