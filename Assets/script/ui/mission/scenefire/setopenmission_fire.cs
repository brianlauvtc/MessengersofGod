using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setopenmission_fire : MonoBehaviour
{   
    public fire_mission1 fm1;
    public fire_mission2 fm2;
    public fire_mission3 fm3;
    public fire_mission4 fm4;
    public fire_mission5 fm5;
    public fire_mission6 fm6;
    public GameObject fm1canvas;
    public GameObject fm2canvas;
    public GameObject fm3canvas;
    public GameObject fm4canvas;
    public GameObject fm5canvas;
    public GameObject fm6canvas;
    public openMission om;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fm1.accept == false && fm1.done == false)
        {
            om.mission = null;
        }
        if (fm1.accept == true && fm1.done == false)
        {
            om.mission = fm1canvas;
        }
        if (fm1.accept == true && fm1.done == true && fm2.accept == false)
        {
            om.mission = null;
        }
        if (fm2.accept == true && fm2.done == false )
        {
            om.mission = fm2canvas;
        }

        if (fm2.accept == true && fm2.done == true && fm3.accept == false)
        {
            om.mission = null;
        }
        if (fm3.accept == true && fm3.done == false)
        {
            om.mission = fm3canvas;
        }

        if (fm3.accept == true && fm3.done == true && fm4.accept == false)
        {
            om.mission = null;
        }
        if (fm4.accept == true && fm4.done == false)
        {
            om.mission = fm4canvas;
        }
        if (fm4.accept == true && fm4.done == true && fm5.accept == false)
        {
            om.mission = null;
        }
        if (fm5.accept == true && fm5.done == false)
        {
            om.mission = fm5canvas;
        }
        if (fm5.accept == true && fm5.done == true && fm6.accept == false)
        {
            om.mission = null;
        }
        if (fm6.accept == true && fm6.done == false)
        {
            om.mission = fm6canvas;
        }
        if (fm6.accept == true && fm6.done == true)
        {
            om.mission = null;
        }

    }
}
