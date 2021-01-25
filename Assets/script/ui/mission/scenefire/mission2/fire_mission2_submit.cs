using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission2_submit : MonoBehaviour
{
    public fire_mission2 fire_mission2_object;
    public GameObject mission2_canvas;
    public Inventory inventorygrid;
    public GameObject question;
    public AudioSource backgroundsound;
    public AudioSource bosssound;
    public AudioSource talksound;
    public float bossvolum;
    public float bgvolum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void missiondone()
    {
     
        fire_mission2_object.done = true;
        player.scenefire_m2 = true;
        player.exp += fire_mission2_object.successexp;
        player.money += fire_mission2_object.successmoney;
        for (int i = 0; i < fire_mission2_object.reward.Length; i++)
        {
            if (fire_mission2_object.reward[i] != null)
            {
                for (int k = 0; k < fire_mission2_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(fire_mission2_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission2_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
