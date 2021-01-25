using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setopenmission_earth : MonoBehaviour
{   
    public earth_mission1 em1;
    public earth_mission2 em2;
    public earth_mission3 em3;
    public earth_mission4 em4;
    public earth_mission5 em5;
    public earth_mission6 em6;
    public GameObject em1canvas;
    public GameObject em2canvas;
    public GameObject em3canvas;
    public GameObject em4canvas;
    public GameObject em5canvas;
    public GameObject em6canvas;
    public openMission om;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (em1.accept == false && em1.done == false)
        {
            om.mission = null;
        }
        if (em1.accept == true && em1.done == false)
        {
            om.mission = em1canvas;
        }
        if (em1.accept == true && em1.done == true && em2.accept == false)
        {
            om.mission = null;
        }
        if (em2.accept == true && em2.done == false )
        {
            om.mission = em2canvas;
        }

        if (em2.accept == true && em2.done == true && em3.accept == false)
        {
            om.mission = null;
        }
        if (em3.accept == true && em3.done == false)
        {
            om.mission = em3canvas;
        }

        if (em3.accept == true && em3.done == true && em4.accept == false)
        {
            om.mission = null;
        }
        if (em4.accept == true && em4.done == false)
        {
            om.mission = em4canvas;
        }
        if (em4.accept == true && em4.done == true && em5.accept == false)
        {
            om.mission = null;
        }
        if (em5.accept == true && em5.done == false)
        {
            om.mission = em5canvas;
        }
        if (em5.accept == true && em5.done == true && em6.accept == false)
        {
            om.mission = null;
        }
        if (em6.accept == true && em6.done == false)
        {
            om.mission = em6canvas;
        }
        if (em6.accept == true && em6.done == true)
        {
            om.mission = null;
        }

    }
}
