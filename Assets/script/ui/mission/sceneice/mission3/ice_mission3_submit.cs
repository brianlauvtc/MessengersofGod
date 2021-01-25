using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission3_submit : MonoBehaviour
{
    public ice_mission3 ice_mission3_object;
    public GameObject mission3_canvas;
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

        ice_mission3_object.done = true;
        player.sceneice_m3 = true;
        player.exp += ice_mission3_object.successexp;
        player.money += ice_mission3_object.successmoney;
        for (int i = 0; i < ice_mission3_object.reward.Length; i++)
        {
            if (ice_mission3_object.reward[i] != null)
            {
                for (int k = 0; k < ice_mission3_object.reward_count[i]; k++)
                {
                    inventorygrid.AddItem(ice_mission3_object.reward[i]);
                }
            }
        }
        question.SetActive(false);
        mission3_canvas.SetActive(false);
        backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
      
    }
}
