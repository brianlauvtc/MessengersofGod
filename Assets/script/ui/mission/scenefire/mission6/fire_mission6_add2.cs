using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission6_add2 : MonoBehaviour
{
    
    public crystal_Character_Attribute mca;
    public fire_mission6 fire_mission6_object;
    public bool dead;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenefire_m6 == false && player.scenefire_m6_accept == true)
        {
            if (mca.HealthPoint <= 0 && dead == false)
            {
                if (fire_mission6_object.killcount2 < fire_mission6_object.maxkillcount2)
                {
                    dead = true;
                    fire_mission6_object.killcount2++;
                }

            }
        }
    }
    
   }


