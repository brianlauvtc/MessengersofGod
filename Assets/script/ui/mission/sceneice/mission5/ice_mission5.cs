using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_mission5 : MonoBehaviour
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
        accept = player.sceneice_m5_accept;
        done = player.sceneice_m5;

        if (accept == true)
        {
            acceptbutton.SetActive(false);
            missionlable.text = "Kill " + maxkillcount + " Demon : ( " + killcount + " / " + maxkillcount + " )";

            if (killcount == maxkillcount)
            {
                submitbutton.SetActive(true); if (player.sceneice_m5 == false) { question.SetActive(true); }

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
