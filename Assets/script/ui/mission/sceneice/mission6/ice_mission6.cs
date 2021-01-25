using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_mission6 : MonoBehaviour
{
    public bool accept;
    public bool done;
    public GameObject acceptbutton;
    public GameObject submitbutton;
    public int killcount;
    public int maxkillcount;
    public int killcount2;
    public int maxkillcount2;
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
        accept = player.sceneice_m6_accept;
        done = player.sceneice_m6;

        if (accept == true)
        {
            missionlable.text = "Kill "+ maxkillcount + " Ice Wizazd : ( " + killcount + " / " + maxkillcount + " )\n" + "Destroy Crystal : ( " + killcount2 + " / " + maxkillcount2 + " )\n" + "Get four Crystal";
            acceptbutton.SetActive(false);
            if (killcount == maxkillcount && killcount2 == maxkillcount2 )
            {
                submitbutton.SetActive(true); if (player.sceneice_m6 == false) { question.SetActive(true); }

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
