using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setcount_sceneearth_mission : MonoBehaviour
{
    
    public earth_mission2 em2;
    public earth_mission3 em3;
    public earth_mission4 em4;
    public earth_mission5 em5;
    public earth_mission6 em6;
    // Start is called before the first frame update
    void Start()
    {
      
        em2.killcount = player.sceneearth_m2_killcount;
        em3.killcount = player.sceneearth_m3_killcount;
        em4.killcount = player.sceneearth_m4_killcount;
        em5.killcount = player.sceneearth_m5_killcount;
        em6.killcount = player.sceneearth_m6_killcount;
        em6.killcount2 = player.sceneearth_m6_killcount2;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
