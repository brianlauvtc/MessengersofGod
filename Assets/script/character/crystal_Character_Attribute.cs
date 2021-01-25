using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crystal_Character_Attribute : MonoBehaviour {
    public float HealthPoint;
    public float Max_HealthPoint;
    public float Defense;
    public float attack_damage;
    public int deadmoney, deadexp;
    public Inventory inventory;
    public GameObject place;
    public InventoryItem crystal;
    public string scenemane;

    // Use this for initialization
    void Start () {
        


    }
	
	
	void Update () {
    

        if (HealthPoint > Max_HealthPoint)
        {
            HealthPoint = Max_HealthPoint;
        }
        if (HealthPoint <= 0)
        {
           
           
           
           
          
            if (scenemane == "scenefire")
            { if (player.scenefire_m6 == false && player.scenefire_m6_accept == true) { if (player.fire_Crystal == false) { inventory.AddItem(crystal); this.gameObject.transform.position = place.transform.position; } player.fire_Crystal = true; }  }
            if (scenemane == "scenewater")
            {
                if (player.scenewater_m6 == false && player.scenewater_m6_accept == true) { if (player.water_Crystal == false) { inventory.AddItem(crystal); this.gameObject.transform.position = place.transform.position; } player.water_Crystal = true; }
            }
            if (scenemane == "sceneearth")
            { if (player.sceneearth_m6 == false && player.sceneearth_m6_accept == true) { if (player.earth_Crystal == false) { inventory.AddItem(crystal); this.gameObject.transform.position = place.transform.position; } player.earth_Crystal = true; } }
            if (scenemane == "sceneice")
            { if (player.sceneice_m6 == false && player.sceneice_m6_accept == true) { if (player.ice_Crystal == false) { inventory.AddItem(crystal); this.gameObject.transform.position = place.transform.position; } player.ice_Crystal = true; } }
           
          
        }


        if (Defense > 1000) 
        {
            Defense = 1000;
        }

       
	}

    public void get_damage(int damage)
    {
          
           HealthPoint -= Mathf.Round(damage * (1 - Defense / 1000));
    }
  
}
