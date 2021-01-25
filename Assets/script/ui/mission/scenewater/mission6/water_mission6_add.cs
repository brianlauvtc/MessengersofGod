using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_mission6_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public water_mission6 water_mission6_object;
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
        if (player.scenewater_m6 == false && player.scenewater_m6_accept == true)
        {
            if (mca.HealthPoint <= 0 && dead == false)
            {
                if (water_mission6_object.killcount < water_mission6_object.maxkillcount)
                {
                    dead = true;
                    water_mission6_object.killcount++;
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
