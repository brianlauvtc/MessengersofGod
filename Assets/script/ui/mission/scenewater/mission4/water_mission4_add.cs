using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission4_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public water_mission4 water_mission4_object;
 

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
        if (water_mission4_object.killcount < water_mission4_object.maxkillcount)
        {

            water_mission4_object.killcount++;

        }
    }

  }


