using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fire_mission1_accept : MonoBehaviour
{
    public fire_mission1 fire_mission1_object;
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
        fire_mission1_object.accept = true;
        player.scenefire_m1_accept = true;
 
        acceptbutton.SetActive(false);


    }
}
