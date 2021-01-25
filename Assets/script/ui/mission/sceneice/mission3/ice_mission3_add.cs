using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_mission3_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public ice_mission3 ice_mission3_object;
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
        if (player.sceneice_m2 == false && player.sceneice_m2_accept == true)
        {      if (mca.HealthPoint <= 0 && dead == false)
            {
                if (ice_mission3_object.killcount < ice_mission3_object.maxkillcount)
                {
                    dead = true;
                    ice_mission3_object.killcount++;
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
