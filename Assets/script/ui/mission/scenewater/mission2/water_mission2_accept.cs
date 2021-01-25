using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class water_mission2_accept : MonoBehaviour
{
    public water_mission2 water_mission2_object;
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
        water_mission2_object.accept = true;
        player.scenewater_m2_accept = true;
       
        acceptbutton.SetActive(false);


    }
}
