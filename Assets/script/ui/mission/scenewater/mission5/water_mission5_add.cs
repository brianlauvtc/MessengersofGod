using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission5_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public water_mission5 water_mission5_object;
    public bool dead;
    public float disappeartime;
    public float respawntime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenewater_m5 == false && player.scenewater_m5_accept == true)
        {  if (mca.HealthPoint <= 0 && dead == false)
            {
                if (water_mission5_object.killcount < water_mission5_object.maxkillcount)
                {
                    dead = true;
                    water_mission5_object.killcount++;
                    StartCoroutine(disappear());
                }
            }
        }
    }
    IEnumerator disappear()
    {
        yield return new WaitForSeconds(disappeartime);        
        StartCoroutine(respawn());
    }
    IEnumerator respawn()
    {
        yield return new WaitForSeconds(respawntime);
        
        dead = false;
       

    }

}
