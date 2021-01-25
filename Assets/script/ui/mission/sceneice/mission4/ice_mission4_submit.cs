using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission4_submit : MonoBehaviour
{
    public ice_mission4 ice_mission4_object;
    public GameObject mission4_canvas;
    public InventoryItem missionitem;
    public Inventory inventorygrids;
    public int a; public GameObject question;

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
        ice_mission4_object.done = true;
        player.sceneice_m4 = true;
        player.exp += ice_mission4_object.successexp;
        player.money += ice_mission4_object.successmoney;
        for (int i = 0; i < ice_mission4_object.reward.Length; i++)
        {
            if (ice_mission4_object.reward[i] != null)
            {
                for (int k = 0; k < ice_mission4_object.reward_count[i]; k++)
                {
                    inventorygrids.AddItem(ice_mission4_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission4_canvas.SetActive(false);
        backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
       
    }
}
