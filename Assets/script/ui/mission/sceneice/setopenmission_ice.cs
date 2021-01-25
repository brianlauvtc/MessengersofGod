using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setopenmission_ice : MonoBehaviour
{   
    public ice_mission1 im1;
    public ice_mission2 im2;
    public ice_mission3 im3;
    public ice_mission4 im4;
    public ice_mission5 im5;
    public ice_mission6 im6;
    public GameObject im1canvas;
    public GameObject im2canvas;
    public GameObject im3canvas;
    public GameObject im4canvas;
    public GameObject im5canvas;
    public GameObject im6canvas;
    public openMission om;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (im1.accept == false && im1.done == false)
        {
            om.mission = null;
        }
        if (im1.accept == true && im1.done == false)
        {
            om.mission = im1canvas;
        }
        if (im1.accept == true && im1.done == true && im2.accept == false)
        {
            om.mission = null;
        }
        if (im2.accept == true && im2.done == false )
        {
            om.mission = im2canvas;
        }

        if (im2.accept == true && im2.done == true && im3.accept == false)
        {
            om.mission = null;
        }
        if (im3.accept == true && im3.done == false)
        {
            om.mission = im3canvas;
        }

        if (im3.accept == true && im3.done == true && im4.accept == false)
        {
            om.mission = null;
        }
        if (im4.accept == true && im4.done == false)
        {
            om.mission = im4canvas;
        }
        if (im4.accept == true && im4.done == true && im5.accept == false)
        {
            om.mission = null;
        }
        if (im5.accept == true && im5.done == false)
        {
            om.mission = im5canvas;
        }
        if (im5.accept == true && im5.done == true && im6.accept == false)
        {
            om.mission = null;
        }
        if (im6.accept == true && im6.done == false)
        {
            om.mission = im6canvas;
        }
        if (im6.accept == true && im6.done == true)
        {
            om.mission = null;
        }

    }
}
