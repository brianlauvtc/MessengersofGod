using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class water_mission4_accept : MonoBehaviour
{
    public water_mission4 water_mission4_object;
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
        water_mission4_object.accept = true;
        player.scenewater_m4_accept = true;
        acceptbutton.SetActive(false);


    }
}
