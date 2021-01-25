using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_mission5_submit : MonoBehaviour
{
    public earth_mission5 earth_mission5_object;
    public GameObject mission5_canvas;
    public InventoryItem missionitem;
    public Inventory inventorygrids;
    public int a; public GameObject question; public AudioSource backgroundsound;
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
        for (int i = 0; i < 21; i++)
        {
            if (inventorygrids.items[i] == missionitem)
            {
                for (int g = 0; g < a; g++)
                { inventorygrids.RemoveItem(missionitem, i); }
            }
        }

        earth_mission5_object.done = true;
        player.sceneearth_m5 = true;
        player.exp += earth_mission5_object.successexp;
        player.money += earth_mission5_object.successmoney;
        for (int i = 0; i < earth_mission5_object.reward.Length; i++)
        {
            if (earth_mission5_object.reward[i] != null)
            {
                for (int k = 0; k < earth_mission5_object.reward_count[i]; k++)
                {
                    inventorygrids.AddItem(earth_mission5_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission5_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
