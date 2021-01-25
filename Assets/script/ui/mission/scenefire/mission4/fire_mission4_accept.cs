using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fire_mission4_accept : MonoBehaviour
{
    public fire_mission4 fire_mission4_object;
    public GameObject acceptbutton;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void accept_mission()
    {
        fire_mission4_object.accept = true;
        player.scenefire_m4_accept = true;
        acceptbutton.SetActive(false);


    }
}
