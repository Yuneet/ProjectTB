using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class potal : MonoBehaviour
{

    public Transform feetPos;
    public float checkRadius;
    public LayerMask layer;
    public bool isPortal = false;
    public Rigidbody2D rigid;
    public int potalnumber;
    public cameracc maincamera;
    public Image loadbar;
    public GameObject buttonobj;
    //public GameObject npcobj;
    public GameObject loadobj;
    public GameObject player;
    private float SetStart;
    public int potalnumber2;
    //public Button button;
    //public float timer;

    // Start is called before the first frame update
    public void Awaek()
    {

    }
    void Start()
    {
      
    }

    public void Click()
    {
        SetStart = PlayerPrefs.GetFloat("setstart", 0);
        //SceneManager.LoadScene(1);
        buttonobj.SetActive(false);
        //npcobj.SetActive(false);
        loadobj.SetActive(true);
        if (SetStart == 0)
        {
            StopCoroutine(LodeScenes(potalnumber2));
            StartCoroutine(LodeScenes(potalnumber2));
        }
        else if (SetStart == 1)
        {
            StopCoroutine(LodeScenes(potalnumber));
            StartCoroutine(LodeScenes(potalnumber));
        }
        /*StopCoroutine(LodeScenes());
        StartCoroutine(LodeScenes());*/
    }

    public void Click2()
    {
        StopCoroutine(LodeScenes(potalnumber2));
        StartCoroutine(LodeScenes(potalnumber2));
    }

    // Update is called once per frame
    void Update()
    {
        /*isPortal = Physics2D.OverlapCircle(feetPos.position, checkRadius, layer);
        if(isPortal == true)
        {
            //SceneManager.LoadScene(potalnumber);
            StopCoroutine(LodeScenes());
            StartCoroutine(LodeScenes());
            Debug.Log(1);
        }*/
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Player")
        {
            player.SetActive(false);
            buttonobj.SetActive(false);
            //npcobj.SetActive(false);
            loadobj.SetActive(true);

            StopCoroutine(LodeScenes(potalnumber));
            StartCoroutine(LodeScenes(potalnumber));                     
        }
    }

    public IEnumerator LodeScenes(int namber) {

        player.SetActive(false);
        buttonobj.SetActive(false);
        loadobj.SetActive(true);

        float timer = 0f;
        while (timer < 1)
        {
            timer += 0.01f;
            loadbar.fillAmount = timer;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(namber);

        /*AsyncOperation op = SceneManager.LoadSceneAsync(namber); // 비 정기적으로 로딩씬
        op.allowSceneActivation = false;
        player.SetActive(false);
        buttonobj.SetActive(false);
        loadobj.SetActive(true);

        float timer = 0.0f;
        
        while (!op.isDone)
        {
            timer += 0.02f;
            if (timer < 10)
            {
                Debug.Log(timer);
                loadbar.fillAmount = timer / 10f;
            }

            if (timer > 10)
            {
                op.allowSceneActivation = true;
                break;
            }
            yield return null;
        }*/


        //Debug.Log("로딩화면 보여주기");
        /*yield return new WaitForSeconds(5);
        SceneManager.LoadScene(potalnumber);*/
    }


    /*void OnEnable()
    {
        SceneManager.sceneLoaded += OnsceneLoaded;
    }
    void OnsceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(1);
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnsceneLoaded;
    }*/
}
