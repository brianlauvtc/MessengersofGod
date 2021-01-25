using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_mission3 : MonoBehaviour
{
    public bool accept;
    public bool done;
    public GameObject acceptbutton;
    public GameObject submitbutton;
    public int killcount;
    public int maxkillcount;
    public Text missionlable;
    public int successmoney;
    public int successexp;
    public openMission om;
    public GameObject missioncanvas;
    public InventoryItem[] reward;
    public int[] reward_count; public GameObject question;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accept = player.sceneice_m3_accept;
        done = player.sceneice_m3;

        if (accept == true)
        {
            acceptbutton.SetActive(false);
            missionlable.text = "Kill " + maxkillcount + " Ice Guard : ( " + killcount + " / " + maxkillcount + " )";

            if (killcount == maxkillcount)
            {
                submitbutton.SetActive(true); if (player.sceneice_m3 == false) { question.SetActive(true); }

            }
            if (done == true)
            {
                if (om.mission == missioncanvas)
                { om.mission = null; }
            }
            if (done == false)
            { om.mission = missioncanvas; }
        }   
    }

   
}
