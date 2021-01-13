using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracc : MonoBehaviour
{
    public GameObject m_Player;
    public Camera mainCamera;

    public static cameracc instance;
    public static cameracc Instance => instance;

    public float shakeTime;
    public float shakeIntensity;
    public float leftx;
    public float rightx;
    playerc playerc;

    public cameracc()
    {
       instance = this;
    }


    // Start is called before the first frame update

    
    void Awake()
    {
       
        playerc = GameObject.Find("Player").GetComponent<playerc>();
    }

    public void Start()
    {
       
    }
    


    // Update is called once per frame
    void Update()
    {
        

        if (playerc.transform.position.x < leftx) //-4.8
        {
            transform.position = new Vector3(transform.position.x, m_Player.transform.position.y, -10);
        }
        else if (playerc.transform.position.x > rightx) { //4.8
            transform.position = new Vector3(transform.position.x, m_Player.transform.position.y, -10);
        }
        else {
            transform.position = new Vector3(m_Player.transform.position.x, m_Player.transform.position.y, -10);
        }

        if (playerc.istag == true)
        {
            OnShakeCamera(0.05f, 0.05f);
        }

    }

    public void OnShakeCamera(float shakeTime=0.05f,float shakeIntensity = 0.05f)
    {
        this.shakeTime = shakeTime;
        this.shakeIntensity = shakeIntensity;

        StopCoroutine("ShakeByPosition");
        StartCoroutine("ShakeByPosition");
    }

    public IEnumerator ShakeByPosition()
    {
        Vector3 startPosition = transform.position;

        while(shakeTime > 0.0f)
        {
            transform.position = startPosition + Random.insideUnitSphere * shakeIntensity;

            shakeTime -= Time.deltaTime;

            yield return null;
        }

        transform.position = startPosition;
    }

  
}
