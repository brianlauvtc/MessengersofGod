using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission5_submit : MonoBehaviour
{
    public water_mission5 water_mission5_object;
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

        water_mission5_object.done = true;
        player.scenewater_m5 = true;
        player.exp += water_mission5_object.successexp;
        player.money += water_mission5_object.successmoney;
        for (int i = 0; i < water_mission5_object.reward.Length; i++)
        {
            if (water_mission5_object.reward[i] != null)
            {
                for (int k = 0; k < water_mission5_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(water_mission5_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission5_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
