using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setcount_sceneice_mission : MonoBehaviour
{
    
    public ice_mission2 im2;
    public ice_mission3 im3;
    public ice_mission4 im4;
    public ice_mission5 im5;
    public ice_mission6 im6;
    // Start is called before the first frame update
    void Start()
    {
      
        im2.killcount = player.sceneice_m2_killcount;
        im3.killcount = player.sceneice_m3_killcount;
        im4.killcount = player.sceneice_m4_killcount;
        im5.killcount = player.sceneice_m5_killcount;
        im6.killcount = player.sceneice_m6_killcount;
        im6.killcount2 = player.sceneice_m6_killcount2;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
