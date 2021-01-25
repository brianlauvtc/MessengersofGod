using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class earth_mission6_accept : MonoBehaviour
{
    public earth_mission6 earth_mission6_object;
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
        earth_mission6_object.accept = true;
        player.sceneearth_m6_accept = true;
        
        acceptbutton.SetActive(false);


    }
}
