using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class spawn_player : MonoBehaviour {

    public GameObject playershooter;
    public GameObject playermage;
    public GameObject playergunner;
    public GameObject playerwarrior;
    public GameObject inventory_canvas;
    public GameObject CharacterInformationCanvas;
    public hotkeylist hkl;
    public Inventory inventory;
    public personalarmor p;
    public GameObject spawnobjectthis;
    public GameObject map;
    public int i;
    gunner_skill_1 gs1;
    gunner_skill_2 gs2;
    gunner_skill_3 gs3;
    gunner_skill_4 gs4;
    Mage_skill_1 ms1;
    Mage_skill_2 ms2;
    Mage_skill_3 ms3;
    Mage_skill_4 ms4;
    Shooter_skill_1 ss1;
    Shooter_skill_2 ss2;
    Shooter_skill_3 ss3;
    Shooter_skill_4 ss4;
    Warrior_skill_1 ws1;
    Warrior_skill_2 ws2;
    Warrior_skill_3 ws3;
    Warrior_skill_4 ws4;

    void Start () {

        if (character_play.i == 1)
        { Instantiate(playershooter, transform.position, transform.rotation);
           
           
        }
        if (character_play.i == 3)
        {   //if ( SceneManager.GetActiveScene().name== "scenewater")
           // { spawnobjectthis.transform.position = new Vector3(spawnobjectthis.transform.position.x, map.transform.position.y, spawnobjectthis.transform.position.z); }
            
            Instantiate(playermage, transform.position, transform.rotation);
          
        }
            if (character_play.i ==2)
        { Instantiate(playerwarrior, transform.position, transform.rotation);
          

        }

        if (character_play.i == 4)
        {
            Instantiate(playergunner, transform.position, transform.rotation);


        }

        for (int i = 0; i < 5; i++)
        {         
            hkl.item[i] = static_hkl_inventory.item[i];
             hkl.num[i] =  static_hkl_inventory.num[i] ;
        }
       
        for (int i = 0; i < 6; i++)
        {
            if (static_hkl_inventory.armor[i] != null)
            {
                if (i == 0)
                {
                    p.headslot = static_hkl_inventory.armor[i];
                    p.headpicture.enabled = true;
                    p.headpicture.sprite = p.headslot.sprite;
                    p.headpicture.name = "headImage = " + p.headslot.Itemname;
                }
                if (i == 1)
                {
                    p.glovesslot = static_hkl_inventory.armor[i];
                    p.glovespicture.enabled = true;
                    p.glovespicture.sprite = p.glovesslot.sprite;
                    p.glovespicture.name = "glovesImage = " + p.glovesslot.Itemname;
                }
                if (i == 2)
                {
                    p.clothesslot = static_hkl_inventory.armor[i];
                    p.clothespicture.enabled = true;
                    p.clothespicture.sprite = p.clothesslot.sprite;
                    p.clothespicture.name = "clothesImage = " + p.clothesslot.Itemname;
                }
                if (i == 3)
                {
                    p.weaponslot = static_hkl_inventory.armor[i];
                    p.weaponpicture.enabled = true;
                    p.weaponpicture.sprite = p.weaponslot.sprite;
                    p.weaponpicture.name = "weaponImage = " + p.weaponslot.Itemname;
                }
                if (i == 4)
                {
                    p.trouserslot = static_hkl_inventory.armor[i];
                    p.trouserpicture.enabled = true;
                    p.trouserpicture.sprite = p.trouserslot.sprite;
                    p.trouserpicture.name = "trouserImage = " + p.trouserslot.Itemname;
                }
                if (i == 5)
                {
                    p.shoeslot = static_hkl_inventory.armor[i];
                    p.shoepicture.enabled = true;
                    p.shoepicture.sprite = p.shoeslot.sprite;
                    p.shoepicture.name = "shoeImage = " + p.shoeslot.Itemname;
                }

            }
            else
            {
                if (i == 0)
                {
                    p.headslot =null;
                    p.headpicture.enabled = false;
                    p.headpicture.sprite = null;
                    p.headpicture.name = "headImage";
                }
                if (i == 1)
                {
                    p.glovesslot = null;
                    p.glovespicture.enabled = false;
                    p.glovespicture.sprite = null;
                    p.glovespicture.name = "glovesImage";
                }
                if (i == 2)
                {
                    p.clothesslot = null;
                    p.clothespicture.enabled = false;
                    p.clothespicture.sprite = null;
                    p.clothespicture.name = "clothesImage" ;
                }
                if (i == 3)
                {
                    p.weaponslot = null;
                    p.weaponpicture.enabled = false;
                    p.weaponpicture.sprite = null;
                    p.weaponpicture.name = "weaponImage" ;
                }
                if (i == 4)
                {
                    p.trouserslot = null;
                    p.trouserpicture.enabled = false;
                    p.trouserpicture.sprite = null;
                    p.trouserpicture.name = "trouserImage" ;
                }
                if (i == 5)
                {
                    p.shoeslot = null;
                    p.shoepicture.enabled = false;
                    p.shoepicture.sprite = null;
                    p.shoepicture.name = "shoeImage" ;
                }
            }
        }
     
        for (int i = 0; i < 21; i++)
        {
            
            if (static_hkl_inventory.items[i] != null)
            {
                print(static_hkl_inventory.items[i].name);
                inventory.items[i] = static_hkl_inventory.items[i];
                inventory.itemCount[i] = static_hkl_inventory.itemCount[i];
                
                if (inventory.items[i] != null) {
                    inventory.counts[i].text = inventory.itemCount[i].ToString();
                    inventory.itemImages[i].sprite = inventory.items[i].sprite;
                    inventory.itemImages[i].name = inventory.items[i].Itemname + " = " + inventory.items[i].ToString();
                    inventory.itemImages[i].enabled = true; }
            }


        }
       
        inventory_canvas.SetActive(false);
        CharacterInformationCanvas.SetActive(false);
        if (character_play.i == 1)
        {
            ss1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_1>();
            ss2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_2>();
            ss3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_3>();
            ss4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_4>();
            ss1.skill_level = player.skill_1_level;
            ss2.skill_level = player.skill_2_level;
            ss3.skill_level = player.skill_3_level;
            ss4.skill_level = player.skill_4_level;
        }
        if (character_play.i == 2)
        {
            ws1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_1>();
            ws2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_2>();
            ws3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_3>();
            ws4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_4>();
            ws1.skill_level = player.skill_1_level;
            ws2.skill_level = player.skill_2_level;
            ws3.skill_level = player.skill_3_level;
            ws4.skill_level = player.skill_4_level;
        }
        if (character_play.i == 3)
        {
            ms1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_1>();
            ms2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_2>();
            ms3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_3>();
            ms4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_4>();
            ms1.skill_level = player.skill_1_level;
            ms2.skill_level = player.skill_2_level;
            ms3.skill_level = player.skill_3_level;
            ms4.skill_level = player.skill_4_level;
        }
        if (character_play.i == 4)
        {
            gs1 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_1>();
            gs2 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_2>();
            gs3 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_3>();
            gs4 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_4>();
            gs1.skill_level = player.skill_1_level;
            gs2.skill_level = player.skill_2_level;
            gs3.skill_level = player.skill_3_level;
            gs4.skill_level = player.skill_4_level;
        }

    }
	
	// Update is called once per frame
	void Update () {
        


        
	}
}
