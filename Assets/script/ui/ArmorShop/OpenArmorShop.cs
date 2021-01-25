using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenArmorShop : MonoBehaviour
{
    public AudioSource  opensound;
    public GameObject canvas;
    public Ray ray;
    public GameObject ESCcanvas;
    Camera main_camera;
    public GameObject player2;
    public Animator talk;
    public float animetime;
    public GameObject[] Canvascount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        main_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        player2 = GameObject.FindGameObjectWithTag("Player");
        if (ESCcanvas.activeInHierarchy == false && player.dead == false)
        {
            ray = main_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit)
                && hit.transform.gameObject.tag == "ArmorShopkeeper")
            {
                if (Vector3.Distance(hit.transform.gameObject.transform.position, player2.transform.position) <= 3f)
                {
                    int kk = 0;
                    for (int i = 0; i < Canvascount.Length; i++)
                    {
                        if (Canvascount[i].activeInHierarchy == false)
                        {
                            kk++;
                        }
                    }if (kk == Canvascount.Length)
                    { canvas.SetActive(true); opensound.Play(); StartCoroutine(weapon()); talk.SetBool("talk", true); StartCoroutine(anime()); }
                }
            }
        }

        }
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        opensound.Stop();
    }
    IEnumerator anime()
    {
        yield return new WaitForSeconds(animetime);
        talk.SetBool("talk", false);
    }
}
