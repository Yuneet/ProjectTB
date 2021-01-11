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
        transform.position = new Vector3(m_Player.transform.position.x, m_Player.transform.position.y, -10);

        /*if (m_Player.transform.position.y >= 1.44f)
        {

            transform.position = new Vector3(m_Player.transform.position.x, m_Player.transform.position.y, -10);
        }
        else
        {
            transform.position = new Vector3(m_Player.transform.position.x, 1.44f, -10);
        }*/

    }

    public void OnShakeCamera(float shakeTime = 1.0f, float shakeIntensity = 0.05f)
    {
        this.shakeTime = shakeTime;
        this.shakeIntensity = shakeIntensity;

        StopCoroutine("ShakeByPosition");
        StartCoroutine("ShakeByPosition");
    }

    public IEnumerator ShakeByPosition()
    {
        Vector3 startPosition = transform.position;

        while (shakeTime > 0.0f)
        {
            transform.position = startPosition + Random.insideUnitSphere * shakeIntensity;

            shakeTime -= Time.deltaTime;

            yield return null;
        }

        transform.position = startPosition;
    }

}
