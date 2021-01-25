using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission5_submit : MonoBehaviour
{
    public fire_mission5 fire_mission5_object;
    public GameObject mission5_canvas;
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
       
        fire_mission5_object.done = true;
        player.scenefire_m5 = true;
        player.exp += fire_mission5_object.successexp;
        player.money += fire_mission5_object.successmoney;
        for (int i = 0; i < fire_mission5_object.reward.Length; i++)
        {
            if (fire_mission5_object.reward[i] != null)
            {
                for (int k = 0; k < fire_mission5_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(fire_mission5_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission5_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
