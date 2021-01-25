using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setcount_scenewater_mission : MonoBehaviour
{
    
    public water_mission2 wm2;
    public water_mission3 wm3;
    public water_mission4 wm4;
    public water_mission5 wm5;
    public water_mission6 wm6;
    // Start is called before the first frame update
    void Start()
    {
      
        wm2.killcount = player.scenewater_m2_killcount;
        wm3.killcount = player.scenewater_m3_killcount;
        wm4.killcount = player.scenewater_m4_killcount;
        wm5.killcount = player.scenewater_m5_killcount;
        wm6.killcount = player.scenewater_m6_killcount;
        wm6.killcount2 = player.scenewater_m6_killcount2;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
