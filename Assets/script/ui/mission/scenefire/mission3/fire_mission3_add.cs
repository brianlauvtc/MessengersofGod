using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission3_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public fire_mission3 fire_mission3_object;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add1()
    {   
        if (fire_mission3_object.killcount < fire_mission3_object.maxkillcount)
        {

            fire_mission3_object.killcount++;

        }
    }

}
