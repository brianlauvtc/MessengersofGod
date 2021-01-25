using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_mission5_accept : MonoBehaviour
{
    public ice_mission5 ice_mission5_object;
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
        ice_mission5_object.accept = true;
        player.sceneice_m5_accept = true;
       
        acceptbutton.SetActive(false);


    }
}
