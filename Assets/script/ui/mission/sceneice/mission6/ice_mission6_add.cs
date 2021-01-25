using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission6_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public ice_mission6 ice_mission6_object;
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
        if (player.sceneice_m6 == false && player.sceneice_m6_accept == true)
        { if (mca.HealthPoint <= 0 && dead == false)
            {
                if (ice_mission6_object.killcount < ice_mission6_object.maxkillcount)
                {
                    dead = true;
                    ice_mission6_object.killcount++;
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
