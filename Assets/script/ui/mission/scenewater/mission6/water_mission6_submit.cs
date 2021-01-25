using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission6_submit : MonoBehaviour
{
    public water_mission6 water_mission6_object;
    public GameObject mission6_canvas;
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

        water_mission6_object.done = true;
        player.scenewater_m6 = true;
        player.exp += water_mission6_object.successexp;
        player.money += water_mission6_object.successmoney;
        for (int i = 0; i < water_mission6_object.reward.Length; i++)
        {
            if (water_mission6_object.reward[i] != null)
            {
                for (int k = 0; k < water_mission6_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(water_mission6_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission6_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
