using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_mission6_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public fire_mission6 fire_mission6_object;
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
        if (player.scenefire_m6 == false && player.scenefire_m6_accept == true)
        {    if (mca.HealthPoint <= 0 && dead == false)
            {
                if (fire_mission6_object.killcount < fire_mission6_object.maxkillcount)
                {
                    dead = true;
                    fire_mission6_object.killcount++;
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
