using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission2_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public fire_mission2 fire_mission2_object;
    public bool dead;
    public float disappeartime;
    public float respawntime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(player.scenefire_m2 == false && player.scenefire_m2_accept == true)
        {  if (mca.HealthPoint <= 0 && dead == false)
            {
                dead = true;
                if (fire_mission2_object.killcount < fire_mission2_object.maxkillcount)
                {
                    fire_mission2_object.killcount++;
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
