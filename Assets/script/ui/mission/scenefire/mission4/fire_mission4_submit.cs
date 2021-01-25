    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission4_submit : MonoBehaviour
{
    public fire_mission4 fire_mission4_object;
    public GameObject mission4_canvas;
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
       
        fire_mission4_object.done = true;
        player.scenefire_m4 = true;
        player.exp += fire_mission4_object.successexp;
        player.money += fire_mission4_object.successmoney;
        for (int i = 0; i < fire_mission4_object.reward.Length; i++)
        {
            if (fire_mission4_object.reward[i] != null)
            {
                for (int k = 0; k < fire_mission4_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(fire_mission4_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission4_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
