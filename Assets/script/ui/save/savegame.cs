using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class savegame : MonoBehaviour
{
    public string scenename;
     public hotkeylist hkl;
     string[] itemname_hotkey = new string[21];
     string[] hotkey_name = new string[21];
     int[] itemnum_hotkey = new int[21];
     string[] hotkey_num = new string[21];

     public Inventory inventorygrid;
     string[] itemname_inventory = new string[21];
     string[] inventory_name = new string[21];
     int[] itemnum_inventory = new int[21];
     string[] inventory_num = new string[21];

    public personalarmor p;
    string[] itemname_armor = new string[6];
    string[] armor_name = new string[6];


    public GameObject missionmanager;
     fire_mission2 fm2;
     fire_mission3 fm3;
     fire_mission4 fm4;
     fire_mission5 fm5;
     fire_mission6 fm6;

    water_mission2 wm2;
    water_mission3 wm3;
    water_mission4 wm4;
    water_mission5 wm5;
    water_mission6 wm6;

    ice_mission2 im2;
    ice_mission3 im3;
    ice_mission4 im4;
    ice_mission5 im5;
    ice_mission6 im6;

    earth_mission2 em2;
    earth_mission3 em3;
    earth_mission4 em4;
    earth_mission5 em5;
    earth_mission6 em6;

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
    public void setinventoryname()
    {
     
        for (int i = 0; i < 21; i++)
        {
            inventory_num[i] = "Gridnum " + i;
            inventory_name[i] = "Gridname " + i;
           
        }
        for (int i = 0; i < 5; i++)
        {
            hotkey_num[i] = "hotkeynum " + i;
            hotkey_name[i] = "hotkeyname " + i;
        }
        for (int i = 0; i < 6; i++)
        {
            armor_name[i] = "armor  " + i;
          
        }

    }

    public void load_skill_level()
    {
      
        if (player.jobname == "shooter")
        {
           
            ss1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_1>();
            ss2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_2>();
            ss3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_3>();
            ss4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_4>();
            player.skill_1_level = ss1.skill_level;
            player.skill_2_level = ss2.skill_level;
            player.skill_3_level = ss3.skill_level;
            player.skill_4_level = ss4.skill_level ;
        }
        if (player.jobname == "warrior")
        {
            ws1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_1>();
            ws2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_2>();
            ws3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_3>();
            ws4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_4>();
            player.skill_1_level = ws1.skill_level;
            player.skill_2_level = ws2.skill_level;
            player.skill_3_level = ws3.skill_level;
            player.skill_4_level = ws4.skill_level;
         
        }
        if (player.jobname == "mage")
        {
            ms1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_1>();
            ms2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_2>();
            ms3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_3>();
            ms4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_4>();
            player.skill_1_level = ms1.skill_level;
            player.skill_2_level = ms2.skill_level;
            player.skill_3_level = ms3.skill_level;
            player.skill_4_level = ms4.skill_level;
        }
        if (player.jobname == "gunman")
        {
            gs1 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_1>();
            gs2 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_2>();
            gs3 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_3>();
            gs4 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_4>();
            player.skill_1_level = gs1.skill_level;
            player.skill_2_level = gs2.skill_level;
            player.skill_3_level = gs3.skill_level;
            player.skill_4_level = gs4.skill_level;
        }
        print("ok1");
    }

    public void savestring()
    {
       
        SaveSystem.SetString("scene_name", player.scene_name); 
        SaveSystem.SetString("player_name", player.player_name); 
        SaveSystem.SetString("jobname", player.jobname);  
    }
    public void saveint()
    {
        
        load_skill_level();
        player.job_num = character_play.i;
       
        SaveSystem.SetInt("job_num", player.job_num);
        SaveSystem.SetInt("money", player.money);
        SaveSystem.SetInt("main_max_exp", player.main_max_exp);
        SaveSystem.SetInt("exp", player.exp);
        SaveSystem.SetInt("max_exp", player.max_exp);
        SaveSystem.SetInt("grow_exp", player.grow_exp);
        SaveSystem.SetInt("skillpoint", player.skillpoint);
        SaveSystem.SetInt("skill_1_level", player.skill_1_level);
        SaveSystem.SetInt("skill_2_level", player.skill_2_level);
        SaveSystem.SetInt("skill_3_level", player.skill_3_level);
        SaveSystem.SetInt("skill_4_level", player.skill_4_level);
        SaveSystem.SetInt("main_attack_damage", player.main_attack_damage);
        SaveSystem.SetInt("level", player.level);
        SaveSystem.SetInt("grow_attack_damage", player.grow_attack_damage);
        SaveSystem.SetInt("attack_damage", player.attack_damage);
        SaveSystem.SetInt("head_hp", player.head_hp);
        SaveSystem.SetInt("gloves_hp", player.gloves_hp);
        SaveSystem.SetInt("clothes_hp", player.clothes_hp);
        SaveSystem.SetInt("shoe_hp", player.shoe_hp);
        SaveSystem.SetInt("trousers_hp", player.trousers_hp);
        SaveSystem.SetInt("weapon_damage", player.weapon_damage);

       
        SaveSystem.SetInt("scenefire_m2_killcount", player.scenefire_m2_killcount);
        SaveSystem.SetInt("scenefire_m3_killcount", player.scenefire_m3_killcount);
        SaveSystem.SetInt("scenefire_m4_killcount", player.scenefire_m4_killcount);
        SaveSystem.SetInt("scenefire_m5_killcount", player.scenefire_m5_killcount);
        SaveSystem.SetInt("scenefire_m6_killcount", player.scenefire_m6_killcount);
        SaveSystem.SetInt("scenefire_m6_killcount2", player.scenefire_m6_killcount2);

        SaveSystem.SetInt("scenewater_m2_killcount", player.scenewater_m2_killcount);
        SaveSystem.SetInt("scenewater_m3_killcount", player.scenewater_m3_killcount);
        SaveSystem.SetInt("scenewater_m4_killcount", player.scenewater_m4_killcount);
        SaveSystem.SetInt("scenewater_m5_killcount", player.scenewater_m5_killcount);
        SaveSystem.SetInt("scenewater_m6_killcount", player.scenewater_m6_killcount);
        SaveSystem.SetInt("scenewater_m6_killcount2", player.scenewater_m6_killcount2);

        SaveSystem.SetInt("sceneearth_m2_killcount", player.sceneearth_m2_killcount);
        SaveSystem.SetInt("sceneearth_m3_killcount", player.sceneearth_m3_killcount);
        SaveSystem.SetInt("sceneearth_m4_killcount", player.sceneearth_m4_killcount);
        SaveSystem.SetInt("sceneearth_m5_killcount", player.sceneearth_m5_killcount);
        SaveSystem.SetInt("sceneearth_m6_killcount", player.sceneearth_m6_killcount);
        SaveSystem.SetInt("sceneearth_m6_killcount2", player.sceneearth_m6_killcount2);

        SaveSystem.SetInt("sceneice_m2_killcount", player.sceneice_m2_killcount);
        SaveSystem.SetInt("sceneice_m3_killcount", player.sceneice_m3_killcount);
        SaveSystem.SetInt("sceneice_m4_killcount", player.sceneice_m4_killcount);
        SaveSystem.SetInt("sceneice_m5_killcount", player.sceneice_m5_killcount);
        SaveSystem.SetInt("sceneice_m6_killcount", player.sceneice_m6_killcount);
        SaveSystem.SetInt("sceneice_m6_killcount2", player.sceneice_m6_killcount2);

    }
    public void savebool()
    {
        SaveSystem.SetBool("fire_Crystal", player.fire_Crystal);
        SaveSystem.SetBool("water_Crystal", player.water_Crystal);
        SaveSystem.SetBool("earth_Crystal", player.earth_Crystal);
        SaveSystem.SetBool("ice_Crystal", player.ice_Crystal);

        SaveSystem.SetBool("fighting_status", player.fighting_status);
        SaveSystem.SetBool("nom_fighting_status", player.nom_fighting_status);
        SaveSystem.SetBool("dead", player.dead);
        SaveSystem.SetBool("isdead", player.isdead);

        SaveSystem.SetBool("scenefire_m1", player.scenefire_m1);
        SaveSystem.SetBool("scenefire_m2", player.scenefire_m2);
        SaveSystem.SetBool("scenefire_m3", player.scenefire_m3);
        SaveSystem.SetBool("scenefire_m4", player.scenefire_m4);
        SaveSystem.SetBool("scenefire_m5", player.scenefire_m5);
        SaveSystem.SetBool("scenefire_m6", player.scenefire_m6);
        print(player.scenefire_m1);
        SaveSystem.SetBool("scenewater_m1", player.scenewater_m1);
        SaveSystem.SetBool("scenewater_m2", player.scenewater_m2);
        SaveSystem.SetBool("scenewater_m3", player.scenewater_m3);
        SaveSystem.SetBool("scenewater_m4", player.scenewater_m4);
        SaveSystem.SetBool("scenewater_m5", player.scenewater_m5);
        SaveSystem.SetBool("scenewater_m6", player.scenewater_m6);
       
        SaveSystem.SetBool("sceneearth_m1", player.sceneearth_m1);
        SaveSystem.SetBool("sceneearth_m2", player.sceneearth_m2);
        SaveSystem.SetBool("sceneearth_m3", player.sceneearth_m3);
        SaveSystem.SetBool("sceneearth_m4", player.sceneearth_m4);
        SaveSystem.SetBool("sceneearth_m5", player.sceneearth_m5);
        SaveSystem.SetBool("sceneearth_m6", player.sceneearth_m6);
     
        SaveSystem.SetBool("sceneice_m1", player.sceneice_m1);
        SaveSystem.SetBool("sceneice_m2", player.sceneice_m2);
        SaveSystem.SetBool("sceneice_m3", player.sceneice_m3);
        SaveSystem.SetBool("sceneice_m4", player.sceneice_m4);
        SaveSystem.SetBool("sceneice_m5", player.sceneice_m5);
        SaveSystem.SetBool("sceneice_m6", player.sceneice_m6);
     

        SaveSystem.SetBool("scenefire_m1_accept", player.scenefire_m1_accept);
        SaveSystem.SetBool("scenefire_m2_accept", player.scenefire_m2_accept);
        SaveSystem.SetBool("scenefire_m3_accept", player.scenefire_m3_accept);
        SaveSystem.SetBool("scenefire_m4_accept", player.scenefire_m4_accept);
        SaveSystem.SetBool("scenefire_m5_accept", player.scenefire_m5_accept);
        SaveSystem.SetBool("scenefire_m6_accept", player.scenefire_m6_accept);
 
        SaveSystem.SetBool("scenewater_m1_accept", player.scenewater_m1_accept);
        SaveSystem.SetBool("scenewater_m2_accept", player.scenewater_m2_accept);
        SaveSystem.SetBool("scenewater_m3_accept", player.scenewater_m3_accept);
        SaveSystem.SetBool("scenewater_m4_accept", player.scenewater_m4_accept);
        SaveSystem.SetBool("scenewater_m5_accept", player.scenewater_m5_accept);
        SaveSystem.SetBool("scenewater_m6_accept", player.scenewater_m6_accept);
      
        SaveSystem.SetBool("sceneearth_m1_accept", player.sceneearth_m1_accept);
        SaveSystem.SetBool("sceneearth_m2_accept", player.sceneearth_m2_accept);
        SaveSystem.SetBool("sceneearth_m3_accept", player.sceneearth_m3_accept);
        SaveSystem.SetBool("sceneearth_m4_accept", player.sceneearth_m4_accept);
        SaveSystem.SetBool("sceneearth_m5_accept", player.sceneearth_m5_accept);
        SaveSystem.SetBool("sceneearth_m6_accept", player.sceneearth_m6_accept);
    
        SaveSystem.SetBool("sceneice_m1_accept", player.sceneice_m1_accept);
        SaveSystem.SetBool("sceneice_m2_accept", player.sceneice_m2_accept);
        SaveSystem.SetBool("sceneice_m3_accept", player.sceneice_m3_accept);
        SaveSystem.SetBool("sceneice_m4_accept", player.sceneice_m4_accept);
        SaveSystem.SetBool("sceneice_m5_accept", player.sceneice_m5_accept);
        SaveSystem.SetBool("sceneice_m6_accept", player.sceneice_m6_accept);



        SaveSystem.SetBool("scenefire_m1_finish", player.scenefire_m1_finish);
        SaveSystem.SetBool("scenewater_m1_finish", player.scenewater_m1_finish);
        SaveSystem.SetBool("sceneearth_m1_finish", player.sceneearth_m1_finish);
        SaveSystem.SetBool("sceneice_m1_finish", player.sceneice_m1_finish);
       


    }
    public void savefloat()
    {
     
        SaveSystem.SetFloat("main_Max_HealthPoint", player.main_Max_HealthPoint);
        SaveSystem.SetFloat("main_ManaPoint", player.main_ManaPoint);
        SaveSystem.SetFloat("main_Max_ManaPoint", player.main_Max_ManaPoint);
        SaveSystem.SetFloat("main_Defense", player.main_Defense);
        SaveSystem.SetFloat("main_Natural_HP_reborn_amount", player.main_Natural_HP_reborn_amount);
        SaveSystem.SetFloat("main_Natural_MP_reborn_amount", player.main_Natural_MP_reborn_amount);
        SaveSystem.SetFloat("grow_Max_HealthPoint", player.grow_Max_HealthPoint);
    
        SaveSystem.SetFloat("grow_ManaPoint", player.grow_ManaPoint);
        SaveSystem.SetFloat("grow_Defense", player.grow_Defense);
        SaveSystem.SetFloat("grow_Natural_HP_reborn_amount", player.grow_Natural_HP_reborn_amount);
        SaveSystem.SetFloat("grow_Natural_MP_reborn_amount", player.grow_Natural_MP_reborn_amount);
        SaveSystem.SetFloat("HealthPoint", player.HealthPoint);
        SaveSystem.SetFloat("Max_HealthPoint", player.Max_HealthPoint);
        SaveSystem.SetFloat("Max_ManaPoint", player.Max_ManaPoint);
        SaveSystem.SetFloat("ManaPoint", player.ManaPoint);
        SaveSystem.SetFloat("Defense", player.Defense);
        SaveSystem.SetFloat("Natural_HP_reborn_amount", player.Natural_HP_reborn_amount);
        SaveSystem.SetFloat("Natural_MP_reborn_amount", player.Natural_MP_reborn_amount);
        SaveSystem.SetFloat("head_Defense", player.head_Defense);
        SaveSystem.SetFloat("gloves_Defense", player.gloves_Defense);
        SaveSystem.SetFloat("clothes_Defense", player.clothes_Defense);
        SaveSystem.SetFloat("shoe_Defense", player.shoe_Defense);
        SaveSystem.SetFloat("trousers_Defense", player.trousers_Defense);
       
    }
    public void saveinventory()
    {
        setinventoryname();
        for (int i = 0; i < 21; i++)
        {       
            if (inventorygrid.items[i] != null)
            {
            
                itemnum_inventory[i] = inventorygrid.itemCount[i];
                itemname_inventory[i] = inventorygrid.items[i].name;
            }
            else { itemname_inventory[i] = ""; itemnum_inventory[i] = 0; }

        }

        for (int i = 0; i < 21; i++)
        {
                
         SaveSystem.SetInt(inventory_num[i], itemnum_inventory[i]);
         SaveSystem.SetString(inventory_name[i], itemname_inventory[i]);
       
            
           
        }
        

    }
    public void savehotkey()
    {
        for (int i = 0; i < 5; i++)
        {
            if (hkl.item[i] != null)
            {
                itemnum_hotkey[i] = hkl.num[i];
                itemname_hotkey[i] = hkl.item[i].name;
            }
            else { itemname_hotkey[i] = ""; itemnum_hotkey[i] = 0; }
        }
        for (int i = 0; i < 5; i++)
        {
          
                SaveSystem.SetInt(hotkey_num[i], itemnum_hotkey[i]);
                SaveSystem.SetString(hotkey_name[i], itemname_hotkey[i]);
            
        }
       
    }
    public void savearmor()
    {
        for (int i = 0; i < 6; i++)
        {
            if (p.armor[i] != null)
            {

                itemname_armor[i] = p.armor[i].name;
            }
            else { itemname_armor[i] = ""; }
        }
        for (int i = 0; i < 6; i++)
        {
           
 
                SaveSystem.SetString(armor_name[i], itemname_armor[i]);
            
        }
       
    }
    public void SaveRecord()
    {
       
        setcomponent();
       
        savemission();
      
        saveinventory();
     
        savehotkey();
       
        savearmor();
       
        savestring();
     
        saveint();
      
        savebool();
        savefloat();

        SaveSystem.SaveToDisk();
       
    }
    public void SaveRecordandexit()
    {
        setcomponent();
        savemission();
        saveinventory();
        savehotkey();
        savearmor();
        savestring();
        saveint();
        savebool();
        savefloat();
        SaveSystem.SaveToDisk();
        Application.LoadLevel("main_scene");
    }
    public void setcomponent()
    {
        if (scenename == "scenefire")
        {
           
            fm2 = missionmanager.GetComponent<fire_mission2>();
            fm3 = missionmanager.GetComponent<fire_mission3>();
            fm4 = missionmanager.GetComponent<fire_mission4>();
            fm5 = missionmanager.GetComponent<fire_mission5>();
            fm6 = missionmanager.GetComponent<fire_mission6>();
        }

        if (scenename == "scenewater")
        {

            wm2 = missionmanager.GetComponent<water_mission2>();
            wm3 = missionmanager.GetComponent<water_mission3>();
            wm4 = missionmanager.GetComponent<water_mission4>();
            wm5 = missionmanager.GetComponent<water_mission5>();
            wm6 = missionmanager.GetComponent<water_mission6>();
        }

        if (scenename == "sceneice")
        {

            im2 = missionmanager.GetComponent<ice_mission2>();
            im3 = missionmanager.GetComponent<ice_mission3>();
            im4 = missionmanager.GetComponent<ice_mission4>();
            im5 = missionmanager.GetComponent<ice_mission5>();
            im6 = missionmanager.GetComponent<ice_mission6>();
        }

        if (scenename  == "sceneearth")
        {

            em2 = missionmanager.GetComponent<earth_mission2>();
            em3 = missionmanager.GetComponent<earth_mission3>();
            em4 = missionmanager.GetComponent<earth_mission4>();
            em5 = missionmanager.GetComponent<earth_mission5>();
            em6 = missionmanager.GetComponent<earth_mission6>();
        }

    }
    public void savemission()
    {
        if (scenename == "scenefire")
        {
           
            player.scenefire_m2_killcount = fm2.killcount;
            player.scenefire_m3_killcount = fm3.killcount;
            player.scenefire_m4_killcount = fm4.killcount;
            player.scenefire_m5_killcount = fm5.killcount;
            player.scenefire_m6_killcount = fm6.killcount;
            player.scenefire_m6_killcount2 = fm6.killcount2;
        }
        if (scenename == "scenewater")
        {

            player.scenewater_m2_killcount = wm2.killcount;
            player.scenewater_m3_killcount = wm3.killcount;
            player.scenewater_m4_killcount = wm4.killcount;
            player.scenewater_m5_killcount = wm5.killcount;
            player.scenewater_m6_killcount = wm6.killcount;
            player.scenewater_m6_killcount2 = wm6.killcount2;
        }
        if (scenename == "sceneice")
        {

            player.sceneice_m2_killcount = im2.killcount;
            player.sceneice_m3_killcount = im3.killcount;
            player.sceneice_m4_killcount = im4.killcount;
            player.sceneice_m5_killcount = im5.killcount;
            player.sceneice_m6_killcount = im6.killcount;
            player.sceneice_m6_killcount2 = im6.killcount2;
        }
        if (scenename == "sceneearth")
        {

            player.sceneearth_m2_killcount = em2.killcount;
            player.sceneearth_m3_killcount = em3.killcount;
            player.sceneearth_m4_killcount = em4.killcount;
            player.sceneearth_m5_killcount = em5.killcount;
            player.sceneearth_m6_killcount = em6.killcount;
            player.sceneearth_m6_killcount2 = em6.killcount2;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
      //  savestring();
      //  saveint();
      //  savebool();
      //  savefloat();
    }
}
