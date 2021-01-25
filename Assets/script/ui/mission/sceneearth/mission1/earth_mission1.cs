using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class earth_mission1 : MonoBehaviour
{
    public bool accept;
    public bool done;
    public AudioSource backgroundsound;
    public AudioSource bosssound;
    public AudioSource talksound;
    Camera main_camera;
    public GameObject player2;
    public GameObject acceptbutton;
    public GameObject submitbutton;
    public Text missionlable;
    public int successmoney;
    public int successexp;
    public GameObject ESCcanvas;
    public GameObject TalkCanvas;
    public bool finish;
    public Ray ray;
    public GameObject missioncanvas;
    public openMission om;
    public Animator a;
    public InventoryItem[] reward;
    public int[] reward_count;
    public GameObject[] Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player2 = GameObject.FindGameObjectWithTag("Player");
        main_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        if (ESCcanvas.activeInHierarchy == false && player.dead == false)
        {
            ray = main_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit)
                && hit.transform.gameObject.tag == "TownHead")
            {
                if (Vector3.Distance(hit.transform.gameObject.transform.position, player2.transform.position) <= 5f)
                {
                    int kk = 0;
                    for (int i = 0; i < Canvas.Length; i++)
                    {
                        if (Canvas[i].activeInHierarchy == false)
                        {
                            kk++;
                        }
                    }
                    if (kk == Canvas.Length)
                    {
                        a.SetBool("hi", true); StartCoroutine(equipment());
                        TalkCanvas.SetActive(true);
                        backgroundsound.volume = 0;
                        bosssound.volume = 0;
                        talksound.Play();
                    }
                }
            }
        }

        accept = player.sceneearth_m1_accept;
        done = player.sceneearth_m1;
        finish = player.sceneearth_m1_finish;
        if (accept == false && done == false)
        { missioncanvas.SetActive(true); }


            if (accept == true)
        {
            acceptbutton.SetActive(false);
            missionlable.text = "Talk to town head - Darnell";
            if (finish == true)
            { submitbutton.SetActive(true); }
            if (done == true)
            {
                if (om.mission == missioncanvas)
                { om.mission = null; }
            }
            if (done == false)
            { om.mission = missioncanvas; }

        }   
    }
  
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(4.367f);
        a.SetBool("hi", false);

    }

}
