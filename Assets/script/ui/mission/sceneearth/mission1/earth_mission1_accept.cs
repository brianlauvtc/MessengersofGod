using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class earth_mission1_accept : MonoBehaviour
{
    public earth_mission1 earth_mission1_object;
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
        earth_mission1_object.accept = true;
        player.sceneearth_m1_accept = true;
 
        acceptbutton.SetActive(false);


    }
}
