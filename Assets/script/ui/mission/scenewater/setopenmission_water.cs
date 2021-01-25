using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setopenmission_water : MonoBehaviour
{   
    public water_mission1 wm1;
    public water_mission2 wm2;
    public water_mission3 wm3;
    public water_mission4 wm4;
    public water_mission5 wm5;
    public water_mission6 wm6;
    public GameObject wm1canvas;
    public GameObject wm2canvas;
    public GameObject wm3canvas;
    public GameObject wm4canvas;
    public GameObject wm5canvas;
    public GameObject wm6canvas;
    public openMission om;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wm1.accept == false && wm1.done == false)
        {
            om.mission = null;
        }
        if (wm1.accept == true && wm1.done == false)
        {
            om.mission = wm1canvas;
        }
        if (wm1.accept == true && wm1.done == true && wm2.accept == false)
        {
            om.mission = null;
        }
        if (wm2.accept == true && wm2.done == false )
        {
            om.mission = wm2canvas;
        }

        if (wm2.accept == true && wm2.done == true && wm3.accept == false)
        {
            om.mission = null;
        }
        if (wm3.accept == true && wm3.done == false)
        {
            om.mission = wm3canvas;
        }

        if (wm3.accept == true && wm3.done == true && wm4.accept == false)
        {
            om.mission = null;
        }
        if (wm4.accept == true && wm4.done == false)
        {
            om.mission = wm4canvas;
        }
        if (wm4.accept == true && wm4.done == true && wm5.accept == false)
        {
            om.mission = null;
        }
        if (wm5.accept == true && wm5.done == false)
        {
            om.mission = wm5canvas;
        }
        if (wm5.accept == true && wm5.done == true && wm6.accept == false)
        {
            om.mission = null;
        }
        if (wm6.accept == true && wm6.done == false)
        {
            om.mission = wm6canvas;
        }
        if (wm6.accept == true && wm6.done == true)
        {
            om.mission = null;
        }

    }
}
