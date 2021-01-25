using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission6_add2 : MonoBehaviour
{
    
    public crystal_Character_Attribute mca;
    public water_mission6 water_mission6_object;
    public bool dead;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mca.HealthPoint <= 0 && dead ==false && player.water_Crystal == false)
        {
            if (water_mission6_object.killcount2 < water_mission6_object.maxkillcount2)
            {
                player.water_Crystal = true;
                   dead = true;
                water_mission6_object.killcount2++;
            }
           
        }
    }
    
   }


