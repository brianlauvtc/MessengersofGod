using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission2_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public water_mission2 water_mission2_object;
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
        if (player.scenewater_m2 == false && player.scenewater_m2_accept == true)
        {  if (mca.HealthPoint <= 0 && dead == false)
            {
                dead = true;
                if (water_mission2_object.killcount < water_mission2_object.maxkillcount)
                {
                    water_mission2_object.killcount++;
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
