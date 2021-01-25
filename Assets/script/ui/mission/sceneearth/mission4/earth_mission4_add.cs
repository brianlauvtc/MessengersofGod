using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_mission4_add : MonoBehaviour
{
    
    public Monster_Character_Attribute mca;
    public earth_mission4 earth_mission4_object;
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
        if (player.sceneearth_m4 == false && player.sceneearth_m4_accept == true)
        {  if (mca.HealthPoint <= 0 && dead == false)
            {
                if (earth_mission4_object.killcount < earth_mission4_object.maxkillcount)
                {
                    dead = true;
                    earth_mission4_object.killcount++;
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
