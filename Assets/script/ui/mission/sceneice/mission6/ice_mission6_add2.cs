using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission6_add2 : MonoBehaviour
{
    
    public crystal_Character_Attribute mca;
    public ice_mission6 ice_mission6_object;
    public bool dead;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mca.HealthPoint <= 0 && dead ==false)
        {
            if (ice_mission6_object.killcount2 < ice_mission6_object.maxkillcount2)
            {
                dead = true;
                ice_mission6_object.killcount2++;
            }
           
        }
    }
    
   }


