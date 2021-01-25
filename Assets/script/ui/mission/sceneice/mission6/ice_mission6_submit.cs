using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission6_submit : MonoBehaviour
{
    public ice_mission6 ice_mission6_object;
    public GameObject mission6_canvas;
    public InventoryItem[] missionitem = new InventoryItem[4];
    public Inventory inventorygrids; public GameObject question;

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
            for (int g = 0; g < missionitem.Length; g++)
            {
                if (inventorygrids.items[i] == missionitem[g])
            {
                 inventorygrids.RemoveItem(missionitem[g], i); 
            }
            }
        }



        ice_mission6_object.done = true;
        player.sceneice_m6 = true;
        player.exp += ice_mission6_object.successexp;
        player.money += ice_mission6_object.successmoney;
        for (int i = 0; i < ice_mission6_object.reward.Length; i++)
        {
            if (ice_mission6_object.reward[i] != null)
            {
                for (int k = 0; k < ice_mission6_object.reward_count[i]; k++)
                {
                    inventorygrids.AddItem(ice_mission6_object.reward[i]);
                } 
            }
        }
        question.SetActive(false);
        mission6_canvas.SetActive(false);
        backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
        
    }
}
