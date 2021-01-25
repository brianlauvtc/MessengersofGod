using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_mission6_accept : MonoBehaviour
{
    public ice_mission6 ice_mission6_object;
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
        ice_mission6_object.accept = true;
        player.sceneice_m6_accept = true;
        
        acceptbutton.SetActive(false);


    }
}
