using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission4_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public ice_mission4 ice_mission4_object;
  

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
        if (ice_mission4_object.killcount < ice_mission4_object.maxkillcount)
        {

            ice_mission4_object.killcount++;

        }
    }

}
