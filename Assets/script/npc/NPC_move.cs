using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_move : MonoBehaviour
{
    public AudioSource movesound;
    public int now;
    public int randomNumber;    
    public bool ok;
    public bool moving;
    public bool done;    
    public Animator animator;
    public GameObject npc;
    public GameObject[] movepoint;
    Camera main_camera;
    public GameObject player2;
    public GameObject ESCcanvas;
    public GameObject MissionCanvas;
    public Ray ray;
    public string npc_name;
    public bool talk;
    public GameObject[] Canvas;
    // Start is called before the first frame update
    void Start()
    {
        talk = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = 1f * Time.deltaTime;
        main_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        player2 = GameObject.FindGameObjectWithTag("Player");
        if (ESCcanvas.activeInHierarchy == false && player.dead == false)
        {
            ray = main_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit)
                && hit.transform.gameObject.name == npc_name)
            {
                if (Vector3.Distance(hit.transform.gameObject.transform.position, player2.transform.position) <= 3f)
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
                        animator.SetBool("talk", true);
                        animator.SetBool("walk", false);
                        talk = true;
                        MissionCanvas.SetActive(true);
                        moving = false;
                        ok = false;
                        done = false;
                        movesound.Stop();
                        step = 0;
                   
                    }
                }
            }
        }
        if (talk == true)
        { npc.transform.LookAt(player2.transform); ok = false;
            moving = false;
            done = false;
        }
        else { step = 1f * Time.deltaTime; }
        if (moving == false && ok == false && talk == false)
        {   
            ok = true;

            StartCoroutine(random());
        }
        if ( moving == true &&  done == true && talk == false)
        {

            if (Vector3.Distance(npc.transform.position, movepoint[randomNumber].transform.position) < 0.1f)
            {
                animator.SetBool("walk", false);
                movesound.Stop();
                ok = false;
                moving = false;
                done = false;
            }
            if (moving == true)
            {
                npc.transform.LookAt(movepoint[randomNumber].transform);
                npc.transform.position = Vector3.MoveTowards(npc.transform.position, movepoint[randomNumber].transform.position, step);

            }

        }
    }

    IEnumerator random()
    {
        yield return new WaitForSeconds(4f);

        do { randomNumber = UnityEngine.Random.Range(0, movepoint.Length); }
        while (randomNumber == now || Vector3.Distance(npc.transform.position, movepoint[randomNumber].transform.position) < 1f);

        moving = true;
        now = randomNumber;
        done = true;
        movesound.Play();
        animator.SetBool("walk", true);



    }
}
