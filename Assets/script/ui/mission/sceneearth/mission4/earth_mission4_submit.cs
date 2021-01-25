using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_mission4_submit : MonoBehaviour
{
    public earth_mission4 earth_mission4_object;
    public GameObject mission4_canvas;
    public Inventory inventorygrid; public GameObject question; public AudioSource backgroundsound;
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

        earth_mission4_object.done = true;
        player.sceneearth_m4 = true;
        player.exp += earth_mission4_object.successexp;
        player.money += earth_mission4_object.successmoney;
        for (int i = 0; i < earth_mission4_object.reward.Length; i++)
        {
            if (earth_mission4_object.reward[i] != null)
            {
                for (int k = 0; k < earth_mission4_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(earth_mission4_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission4_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
