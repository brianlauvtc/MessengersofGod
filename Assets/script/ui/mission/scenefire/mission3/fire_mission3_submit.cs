using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission3_submit : MonoBehaviour
{
    public fire_mission3 fire_mission3_object;
    public GameObject mission3_canvas;
    public InventoryItem missionitem;
    public Inventory inventorygrids;
    public int a;
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
        for (int i = 0; i < 21; i++)
        {
            if (inventorygrids.items[i] == missionitem)
            {
                for (int g = 0; g < a; g++)
                { inventorygrids.RemoveItem(missionitem, i); }
            }
        }
        fire_mission3_object.done = true;
        player.scenefire_m3 = true;
        player.exp += fire_mission3_object.successexp;
        player.money += fire_mission3_object.successmoney;
        for (int i = 0; i < fire_mission3_object.reward.Length; i++)
        {
            if (fire_mission3_object.reward[i] != null)
            {
                for (int k = 0; k < fire_mission3_object.reward_count[i]; k++)
                {
                    inventorygrids.AddItem(fire_mission3_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission3_canvas.SetActive(false); backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
    }
}
