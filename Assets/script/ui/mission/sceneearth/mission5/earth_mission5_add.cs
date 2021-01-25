using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_mission5_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public earth_mission5 earth_mission5_object;
 

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
        if (earth_mission5_object.killcount < earth_mission5_object.maxkillcount)
        {

            earth_mission5_object.killcount++;

        }
    }

}
