using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fire_mission2_accept : MonoBehaviour
{
    public fire_mission2 fire_mission2_object;
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
        fire_mission2_object.accept = true;
        player.scenefire_m2_accept = true;
       
        acceptbutton.SetActive(false);


    }
}
