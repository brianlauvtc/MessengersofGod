using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_mission6_add2 : MonoBehaviour
{
    
    public crystal_Character_Attribute mca;
    public earth_mission6 earth_mission6_object;
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
            if (earth_mission6_object.killcount2 < earth_mission6_object.maxkillcount2)
            {
                dead = true;
                earth_mission6_object.killcount2++;
            }
           
        }
    }
    
   }


