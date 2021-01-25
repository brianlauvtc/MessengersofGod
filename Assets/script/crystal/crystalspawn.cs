using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalspawn : MonoBehaviour
{
    public bool dead;
    public float deadtime;
    public GameObject monster;
    public GameObject crystal;
    public string scenemane;
    public float he;
    public bool spawn;
    Monster_Character_Attribute mca;
    // Start is called before the first frame update
    void Start()
    {
        mca = monster.GetComponent<Monster_Character_Attribute>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mca.HealthPoint <= 0 && dead == false )
        {
            if (scenemane == "scenefire" && player.fire_Crystal == false)
            {
                if (player.scenefire_m6_accept == true && spawn == false)
                {
                    spawn = true;
                    StartCoroutine(crystalspawnmethod());
                }
            }
            if (scenemane == "scenewater" && player.water_Crystal == false)
            {
                if (player.scenewater_m6_accept == true && spawn == false)
                {
                    spawn = true;
                    StartCoroutine(crystalspawnmethod()); }
            }
            if (scenemane == "sceneearth" && player.earth_Crystal == false)
            {
                if (player.sceneearth_m6_accept == true && spawn == false)
                {
                    spawn = true;
                    StartCoroutine(crystalspawnmethod()); }
            }
            if (scenemane == "sceneice" && player.ice_Crystal == false)
            {
                if (player.sceneice_m6_accept == true && spawn == false)
                {
                    spawn = true;
                    StartCoroutine(crystalspawnmethod());
            }
            }      
        }
    }

    IEnumerator crystalspawnmethod()
    {
        yield return new WaitForSeconds(deadtime);
        crystal.transform.position = new Vector3(monster.transform.position.x, monster.transform.position.y + he, monster.transform.position.z);



    }
}
