using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class load_save : MonoBehaviour
{
    public changeimage ci;
    levelLoader Loader;
    public load_item_list itemlist;
     string[] itemname_hotkey = new string[21];
     string[] hotkey_name = new string[21];
     int[] itemnum_hotkey = new int[21];
     string[] hotkey_num = new string[21];
     string[] itemname_inventory = new string[21];
     string[] inventory_name = new string[21];
     int[] itemnum_inventory = new int[21];
     string[] inventory_num = new string[21];
    string[] itemname_armor = new string[6];
    string[] armor_name = new string[6];
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Loader = GameObject.Find("LevelLoader").GetComponent<levelLoader>();
        }
        catch (System.Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
        loadinventory();
        loadhotkey();
        loadarmor();
        for (int i = 0; i < 21; i++)
        {
            if (itemname_inventory[i] == null)
            { static_hkl_inventory.items[i] = null; }
            else
            {for (int j = 0; j < itemlist.Item.Length; j++)
                {
                    if (itemname_inventory[i] == itemlist.Item[j].name)
                    {
                        static_hkl_inventory.items[i] = itemlist.Item[j];
                        static_hkl_inventory.itemCount[i] = itemnum_inventory[i];
                    }
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (itemname_hotkey[i] == null)
            { static_hkl_inventory.item[i] = null; }
            else
            {
                for (int j = 0; j < itemlist.Item.Length; j++)
                {
                    if (itemname_hotkey[i] == itemlist.Item[j].name)
                    {
                        static_hkl_inventory.item[i] = itemlist.Item[j];
                        static_hkl_inventory.num[i] = itemnum_hotkey[i];
                    }
                }
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (itemname_armor[i] == "")
            { static_hkl_inventory.armor[i] = null; }
            else
            {
                for (int j = 0; j < itemlist.Item.Length; j++)
                {
                    if (itemname_armor[i] == itemlist.Item[j].name)
                    {
                        static_hkl_inventory.armor[i] = itemlist.Item[j];
                  
                    }
                }
            }
        }
    }
    public void loadinventory()
    {
        for (int i = 0; i < 21; i++)
        {   if (SaveSystem.GetInt(inventory_num[i]) != 0)
            { itemnum_inventory[i] = SaveSystem.GetInt(inventory_num[i]); }
            else { itemnum_inventory[i] = 0; }
            itemname_inventory[i] =  SaveSystem.GetString(inventory_name[i]);        

        }
    }
    public void loadhotkey()
    {
        for (int i = 0; i < 5; i++)
        {   if (SaveSystem.GetInt(hotkey_num[i]) != 0)
            { itemnum_hotkey[i] = SaveSystem.GetInt(hotkey_num[i]); }
            else { itemnum_hotkey[i] = 0; }
            itemname_hotkey[i] = SaveSystem.GetString(hotkey_name[i]);

        }
    }
    public void loadarmor()
    {
        for (int i = 0; i < 6; i++)
        {

            itemname_armor[i] = SaveSystem.GetString(armor_name[i]);

        }
    }
    public void load()
    {
        setinventoryname();
        loadstring();
        loadint();
        loadfloat();
        loadbool();
        
        character_play.i = player.job_num;
       
        if (Loader == null)
            SceneManager.LoadScene(player.scene_name);
        else
            Loader.LoadLevel(player.scene_name);
    }
    public void loadstring()
    {
        player.scene_name = SaveSystem.GetString("scene_name");
        ci.scenename = SaveSystem.GetString("scene_name");
        player.player_name = SaveSystem.GetString("player_name");
        player.jobname = SaveSystem.GetString("jobname");
    }

    public void loadint()
    {
        player.level = SaveSystem.GetInt("level");
        player.job_num = SaveSystem.GetInt("job_num");
        character_play.i = SaveSystem.GetInt("job_num");
        player.money = SaveSystem.GetInt("money");
        player.exp = SaveSystem.GetInt("exp");
        player.grow_exp = SaveSystem.GetInt("grow_exp");
        player.max_exp = SaveSystem.GetInt("max_exp");
        player.main_max_exp = SaveSystem.GetInt("main_max_exp");
        player.skillpoint = SaveSystem.GetInt("skillpoint");
        player.skill_1_level = SaveSystem.GetInt("skill_1_level");
        player.skill_2_level = SaveSystem.GetInt("skill_2_level");
        player.skill_3_level = SaveSystem.GetInt("skill_3_level");
        player.skill_4_level = SaveSystem.GetInt("skill_4_level");

        player.attack_damage = SaveSystem.GetInt("attack_damage");
        player.grow_attack_damage = SaveSystem.GetInt("grow_attack_damage");
        player.main_attack_damage = SaveSystem.GetInt("main_attack_damage");
        player.head_hp = SaveSystem.GetInt("head_hp");
        player.gloves_hp = SaveSystem.GetInt("gloves_hp");
        player.clothes_hp = SaveSystem.GetInt("clothes_hp");
        player.shoe_hp = SaveSystem.GetInt("shoe_hp");
        player.trousers_hp = SaveSystem.GetInt("trousers_hp");
        player.weapon_damage = SaveSystem.GetInt("weapon_damage");
     
        player.scenefire_m2_killcount = SaveSystem.GetInt("scenefire_m2_killcount");
        player.scenefire_m3_killcount = SaveSystem.GetInt("scenefire_m3_killcount");
        player.scenefire_m4_killcount = SaveSystem.GetInt("scenefire_m4_killcount");
        player.scenefire_m5_killcount = SaveSystem.GetInt("scenefire_m5_killcount");
        player.scenefire_m6_killcount = SaveSystem.GetInt("scenefire_m6_killcount");
        player.scenefire_m6_killcount2 = SaveSystem.GetInt("scenefire_m6_killcount2");

        player.scenewater_m2_killcount = SaveSystem.GetInt("scenewater_m2_killcount");
        player.scenewater_m3_killcount = SaveSystem.GetInt("scenewater_m3_killcount");
        player.scenewater_m4_killcount = SaveSystem.GetInt("scenewater_m4_killcount");
        player.scenewater_m5_killcount = SaveSystem.GetInt("scenewater_m5_killcount");
        player.scenewater_m6_killcount = SaveSystem.GetInt("scenewater_m6_killcount");
        player.scenewater_m6_killcount2 = SaveSystem.GetInt("scenewater_m6_killcount2");

        player.sceneearth_m2_killcount = SaveSystem.GetInt("scenefire_m2_killcount");
        player.sceneearth_m3_killcount = SaveSystem.GetInt("sceneearth_m3_killcount");
        player.sceneearth_m4_killcount = SaveSystem.GetInt("sceneearth_m4_killcount");
        player.sceneearth_m5_killcount = SaveSystem.GetInt("sceneearth_m5_killcount");
        player.sceneearth_m6_killcount = SaveSystem.GetInt("sceneearth_m6_killcount");
        player.sceneearth_m6_killcount2 = SaveSystem.GetInt("sceneearth_m6_killcount2");

        player.sceneice_m2_killcount = SaveSystem.GetInt("sceneice_m2_killcount");
        player.sceneice_m3_killcount = SaveSystem.GetInt("sceneice_m3_killcount");
        player.sceneice_m4_killcount = SaveSystem.GetInt("sceneice_m4_killcount");
        player.sceneice_m5_killcount = SaveSystem.GetInt("sceneice_m5_killcount");
        player.sceneice_m6_killcount = SaveSystem.GetInt("sceneice_m6_killcount");
        player.sceneice_m6_killcount2 = SaveSystem.GetInt("sceneice_m6_killcount2");

    }

    public void loadfloat()
    {
        player.trousers_Defense = SaveSystem.GetFloat("trousers_Defense");
        player.shoe_Defense = SaveSystem.GetFloat("shoe_Defense");
        player.clothes_Defense = SaveSystem.GetFloat("clothes_Defense");
        player.gloves_Defense = SaveSystem.GetFloat("gloves_Defense");
        player.head_Defense = SaveSystem.GetFloat("head_Defense");
        player.Natural_HP_reborn_amount = SaveSystem.GetFloat("Natural_HP_reborn_amount");
        player.Natural_MP_reborn_amount = SaveSystem.GetFloat("Natural_MP_reborn_amount");
        player.grow_Natural_MP_reborn_amount = SaveSystem.GetFloat("grow_Natural_MP_reborn_amount");
        player.grow_Natural_HP_reborn_amount = SaveSystem.GetFloat("grow_Natural_HP_reborn_amount");
        player.main_Natural_MP_reborn_amount = SaveSystem.GetFloat("main_Natural_MP_reborn_amount");
        player.main_Natural_HP_reborn_amount = SaveSystem.GetFloat("main_Natural_HP_reborn_amount");
        player.Defense = SaveSystem.GetFloat("Defense");
        player.grow_Defense = SaveSystem.GetFloat("grow_Defense");
        player.main_Defense = SaveSystem.GetFloat("main_Defense");
        player.ManaPoint = SaveSystem.GetFloat("ManaPoint");
        player.grow_ManaPoint = SaveSystem.GetFloat("grow_ManaPoint");
        player.main_ManaPoint = SaveSystem.GetFloat("main_ManaPoint");
        player.Max_ManaPoint = SaveSystem.GetFloat("Max_ManaPoint");

        player.main_Max_ManaPoint = SaveSystem.GetFloat("main_Max_ManaPoint");
        player.Max_HealthPoint = SaveSystem.GetFloat("Max_HealthPoint");
        player.grow_Max_HealthPoint = SaveSystem.GetFloat("grow_Max_HealthPoint");
        player.main_Max_HealthPoint = SaveSystem.GetFloat("main_Max_HealthPoint");
        player.HealthPoint = SaveSystem.GetFloat("HealthPoint");


    }

    public void loadbool()
    {
        player.fire_Crystal = SaveSystem.GetBool("fire_Crystal");
        player.water_Crystal = SaveSystem.GetBool("water_Crystal");
        player.earth_Crystal = SaveSystem.GetBool("earth_Crystal");
        player.ice_Crystal = SaveSystem.GetBool("ice_Crystal");



        player.fighting_status = SaveSystem.GetBool("fighting_status");
        player.nom_fighting_status = SaveSystem.GetBool("nom_fighting_status");
        player.dead = SaveSystem.GetBool("dead");
        player.isdead = SaveSystem.GetBool("isdead");

        player.scenefire_m1 = SaveSystem.GetBool("scenefire_m1");
        player.scenefire_m2 = SaveSystem.GetBool("scenefire_m2");
        player.scenefire_m3 = SaveSystem.GetBool("scenefire_m3");
        player.scenefire_m4 = SaveSystem.GetBool("scenefire_m4");
        player.scenefire_m5 = SaveSystem.GetBool("scenefire_m5");
        player.scenefire_m6 = SaveSystem.GetBool("scenefire_m6");

       
        player.scenewater_m1 = SaveSystem.GetBool("scenewater_m1");
        player.scenewater_m2 = SaveSystem.GetBool("scenewater_m2");
        player.scenewater_m3 = SaveSystem.GetBool("scenewater_m3");
        player.scenewater_m4 = SaveSystem.GetBool("scenewater_m4");
        player.scenewater_m5 = SaveSystem.GetBool("scenewater_m5");
        player.scenewater_m6 = SaveSystem.GetBool("scenewater_m6");
       

        player.sceneearth_m1 = SaveSystem.GetBool("sceneearth_m1");
        player.sceneearth_m2 = SaveSystem.GetBool("sceneearth_m2");
        player.sceneearth_m3 = SaveSystem.GetBool("sceneearth_m3");
        player.sceneearth_m4 = SaveSystem.GetBool("sceneearth_m4");
        player.sceneearth_m5 = SaveSystem.GetBool("sceneearth_m5");
        player.sceneearth_m6 = SaveSystem.GetBool("sceneearth_m6");
       

        player.sceneice_m1 = SaveSystem.GetBool("sceneice_m1");
        player.sceneice_m2 = SaveSystem.GetBool("sceneice_m2");
        player.sceneice_m3 = SaveSystem.GetBool("sceneice_m3");
        player.sceneice_m4 = SaveSystem.GetBool("sceneice_m4");
        player.sceneice_m5 = SaveSystem.GetBool("sceneice_m5");
        player.sceneice_m6 = SaveSystem.GetBool("sceneice_m6");
    


        player.scenefire_m1_accept = SaveSystem.GetBool("scenefire_m1_accept");
        player.scenefire_m2_accept = SaveSystem.GetBool("scenefire_m2_accept");
        player.scenefire_m3_accept = SaveSystem.GetBool("scenefire_m3_accept");
        player.scenefire_m4_accept = SaveSystem.GetBool("scenefire_m4_accept");
        player.scenefire_m5_accept = SaveSystem.GetBool("scenefire_m5_accept");
        player.scenefire_m6_accept = SaveSystem.GetBool("scenefire_m6_accept");
   

        player.scenewater_m1_accept = SaveSystem.GetBool("scenewater_m1_accept");
        player.scenewater_m2_accept = SaveSystem.GetBool("scenewater_m2_accept");
        player.scenewater_m3_accept = SaveSystem.GetBool("scenewater_m3_accept");
        player.scenewater_m4_accept = SaveSystem.GetBool("scenewater_m4_accept");
        player.scenewater_m5_accept = SaveSystem.GetBool("scenewater_m5_accept");
        player.scenewater_m6_accept = SaveSystem.GetBool("scenewater_m6_accept");
        

        player.sceneearth_m1_accept = SaveSystem.GetBool("sceneearth_m1_accept");
        player.sceneearth_m2_accept = SaveSystem.GetBool("sceneearth_m2_accept");
        player.sceneearth_m3_accept = SaveSystem.GetBool("sceneearth_m3_accept");
        player.sceneearth_m4_accept = SaveSystem.GetBool("sceneearth_m4_accept");
        player.sceneearth_m5_accept = SaveSystem.GetBool("sceneearth_m5_accept");
        player.sceneearth_m6_accept = SaveSystem.GetBool("sceneearth_m6_accept");
     

        player.sceneice_m1_accept = SaveSystem.GetBool("sceneice_m1_accept");
        player.sceneice_m2_accept = SaveSystem.GetBool("sceneice_m2_accept");
        player.sceneice_m3_accept = SaveSystem.GetBool("sceneice_m3_accept");
        player.sceneice_m4_accept = SaveSystem.GetBool("sceneice_m4_accept");
        player.sceneice_m5_accept = SaveSystem.GetBool("sceneice_m5_accept");
        player.sceneice_m6_accept = SaveSystem.GetBool("sceneice_m6_accept");
       


        player.scenefire_m1_finish = SaveSystem.GetBool("scenefire_m1_finish");
        player.scenewater_m1_finish = SaveSystem.GetBool("scenewater_m1_finish");
        player.sceneearth_m1_finish = SaveSystem.GetBool("sceneearth_m1_finish");
        player.sceneice_m1_finish = SaveSystem.GetBool("sceneice_m1_finish");
   

    }
}
