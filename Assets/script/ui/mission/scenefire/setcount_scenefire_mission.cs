using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setcount_scenefire_mission : MonoBehaviour
{
    
    public fire_mission2 fm2;
    public fire_mission3 fm3;
    public fire_mission4 fm4;
    public fire_mission5 fm5;
    public fire_mission6 fm6;
    // Start is called before the first frame update
    void Start()
    {
      
        fm2.killcount = player.scenefire_m2_killcount;
        fm3.killcount = player.scenefire_m3_killcount;
        fm4.killcount = player.scenefire_m4_killcount;
        fm5.killcount = player.scenefire_m5_killcount;
        fm6.killcount = player.scenefire_m6_killcount;
        fm6.killcount2 = player.scenefire_m6_killcount2;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
