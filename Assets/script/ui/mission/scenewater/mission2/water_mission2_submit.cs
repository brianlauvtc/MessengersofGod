using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission2_submit : MonoBehaviour
{
    public water_mission2 water_mission2_object;
    public GameObject mission2_canvas;
    public Inventory inventorygrid; public GameObject question;
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

        water_mission2_object.done = true;
        player.scenewater_m2 = true;
        player.exp += water_mission2_object.successexp;
        player.money += water_mission2_object.successmoney;
        for (int i = 0; i < water_mission2_object.reward.Length; i++)
        {
            if (water_mission2_object.reward[i] != null)
            {
                for (int k = 0; k < water_mission2_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(water_mission2_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission2_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
