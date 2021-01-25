using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opentpcanvas : MonoBehaviour
{
    public GameObject ESCcanvas;
    Camera main_camera;
    public GameObject player2;
    public GameObject TPcanvas;
    public Ray ray;
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
                && hit.transform.gameObject.tag == "tp")
            {
                if (Vector3.Distance(hit.transform.gameObject.transform.position, player2.transform.position) <= 2f)
                {
                    TPcanvas.SetActive(true);
                }
            }
        }
    }
}
