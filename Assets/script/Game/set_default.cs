using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_default : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void setfalse()
    {
        player.dead = false;
        player.count = 0;
        player.isdead = false;
        player.scenefire_m1 = false;
        player.scenefire_m2 = false;
        player.scenefire_m3 = false;
        player.scenefire_m4 = false;
        player.scenefire_m5 = false;
        player.scenefire_m6 = false;

        player.scenewater_m1 = false;
        player.scenewater_m2 = false;
        player.scenewater_m3 = false;
        player.scenewater_m4 = false;
        player.scenewater_m5 = false;
        player.scenewater_m6 = false;

        player.sceneearth_m1 = false;
        player.sceneearth_m2 = false;
        player.sceneearth_m3 = false;
        player.sceneearth_m4 = false;
        player.sceneearth_m5 = false;
        player.sceneearth_m6 = false;

        player.sceneice_m1 = false;
        player.sceneice_m2 = false;
        player.sceneice_m3 = false;
        player.sceneice_m4 = false;
        player.sceneice_m5 = false;
        player.sceneice_m6 = false;


        player.scenefire_m1_accept = false;
        player.scenefire_m2_accept = false;
        player.scenefire_m3_accept = false;
        player.scenefire_m4_accept = false;
        player.scenefire_m5_accept = false;
        player.scenefire_m6_accept = false;

        player.scenewater_m1_accept = false;
        player.scenewater_m2_accept = false;
        player.scenewater_m3_accept = false;
        player.scenewater_m4_accept = false;
        player.scenewater_m5_accept = false;
        player.scenewater_m6_accept = false;

        player.sceneearth_m1_accept = false;
        player.sceneearth_m2_accept = false;
        player.sceneearth_m3_accept = false;
        player.sceneearth_m4_accept = false;
        player.sceneearth_m5_accept = false;
        player.sceneearth_m6_accept = false;

        player.sceneice_m1_accept = false;
        player.sceneice_m2_accept = false;
        player.sceneice_m3_accept = false;
        player.sceneice_m4_accept = false;
        player.sceneice_m5_accept = false;
        player.sceneice_m6_accept = false;

        player.fire_Crystal = false;
        player.water_Crystal = false;
        player.earth_Crystal = false;
        player.ice_Crystal = false;
        player.scenefire_m1_finish = false;
        player.sceneearth_m1_finish = false;
        player.scenewater_m1_finish = false;
        player.sceneice_m1_finish = false;

        player.scenefire_m2_killcount = 0;
        player.scenefire_m3_killcount = 0;
        player.scenefire_m4_killcount = 0;
        player.scenefire_m5_killcount = 0;
        player.scenefire_m6_killcount = 0;
        player.scenefire_m6_killcount2 = 0;


        player.scenewater_m2_killcount = 0;
        player.scenewater_m3_killcount = 0;
        player.scenewater_m4_killcount = 0;
        player.scenewater_m5_killcount = 0;
        player.scenewater_m6_killcount = 0;
        player.scenewater_m6_killcount2 = 0;


        player.sceneearth_m2_killcount = 0;
        player.sceneearth_m3_killcount = 0;
        player.sceneearth_m4_killcount = 0;
        player.sceneearth_m5_killcount = 0;
        player.sceneearth_m6_killcount = 0;
        player.sceneearth_m6_killcount2 = 0;


        player.sceneice_m2_killcount = 0;
        player.sceneice_m3_killcount = 0;
        player.sceneice_m4_killcount = 0;
        player.sceneice_m5_killcount = 0;
        player.sceneice_m6_killcount = 0;
        player.sceneice_m6_killcount2 = 0;
        for (int j = 0; j < 6; j++)
        {
            static_hkl_inventory.armor[j] = null;
        }
        for (int i = 0; i < 5; i++)
        {
            static_hkl_inventory.item[i] = null;
            static_hkl_inventory.num[i] = 0;
        }
        for (int i = 0; i < 21; i++)
        {
            static_hkl_inventory.items[i] = null;
            static_hkl_inventory.itemCount[i] = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (character_play.i == 1)
        {
            player.jobname = "shooter";
            player.exp = 0;
            player.grow_exp = 100;
            player.max_exp = 100;
            player.job_num = 1;
            player.level = 1;
            player.money = 0;
         player.skillpoint = 0;
            player.HealthPoint = 200;
            player.Max_HealthPoint = 200;
            player.grow_Max_HealthPoint = 20;

            player.ManaPoint = 250;
            player.grow_ManaPoint = 20;
            player.Max_ManaPoint = 250;

            player.Defense = 30;
            player.grow_Defense = 2;

            player.attack_damage = 20;
            player.grow_attack_damage = 2;

            player.Natural_HP_reborn_amount = 5;
            player.grow_Natural_HP_reborn_amount = 1;
            player.Natural_MP_reborn_amount = 3;
            player.grow_Natural_MP_reborn_amount = 1;

            player.head_hp=0;
            player.gloves_hp=0;
            player.clothes_hp = 0;
            player.shoe_hp=0;
            player.trousers_hp=0;
            player.weapon_damage=0;
            player.head_Defense = 0;
            player.gloves_Defense = 0;
            player.clothes_Defense = 0;
            player.shoe_Defense = 0;
            player.trousers_Defense = 0;

            player.skill_1_level = 1;
            player.skill_2_level = 1;
            player.skill_3_level = 1;
            player.skill_4_level = 1;
            setfalse();

        }
        if (character_play.i == 2)
        {
            player.jobname = "warrior";
            player.grow_exp = 100;
            player.exp = 0;
            player.max_exp = 100;
            player.job_num = 2;
            player.money = 0;
            player.level = 1;player.skillpoint = 0;

            player.HealthPoint = 320;
            player.Max_HealthPoint = 320;
            player.grow_Max_HealthPoint = 20;

            player.ManaPoint = 300;
            player.grow_ManaPoint = 20;
            player.Max_ManaPoint = 250;

            player.Defense = 50;
            player.grow_Defense = 5;

            player.attack_damage = 30;
            player.grow_attack_damage = 2;

            player.Natural_HP_reborn_amount = 5;
            player.grow_Natural_HP_reborn_amount = 1;
            player.Natural_MP_reborn_amount = 3;
            player.grow_Natural_MP_reborn_amount = 1;

            player.head_hp = 0;
            player.gloves_hp = 0;
            player.clothes_hp = 0;
            player.shoe_hp = 0;
            player.trousers_hp = 0;
            player.weapon_damage = 0;
            player.head_Defense = 0;
            player.gloves_Defense = 0;
            player.clothes_Defense = 0;
            player.shoe_Defense = 0;
            player.trousers_Defense = 0;
            player.skill_1_level = 1;
            player.skill_2_level = 1;
            player.skill_3_level = 1; player.skill_4_level = 1;
            setfalse();
        }
        if (character_play.i == 3)
        {
            player.jobname = "mage";
            player.job_num = 3;
            player.grow_exp = 100;
            player.exp = 0;
            player.max_exp = 100;
			player.skillpoint = 0;

            player.money = 0;
            player.level = 1;

            player.HealthPoint = 150;
            player.Max_HealthPoint = 150;
            player.grow_Max_HealthPoint = 20;

            player.ManaPoint = 300;
            player.grow_ManaPoint = 20;
            player.Max_ManaPoint = 300;

            player.Defense = 30;
            player.grow_Defense = 3;

            player.attack_damage = 20;
            player.grow_attack_damage = 2;

            player.Natural_HP_reborn_amount = 5;
            player.grow_Natural_HP_reborn_amount = 1;
            player.Natural_MP_reborn_amount = 3;
            player.grow_Natural_MP_reborn_amount = 1;

            player.head_hp = 0;
            player.gloves_hp = 0;
            player.clothes_hp = 0;
            player.shoe_hp = 0;
            player.trousers_hp = 0;
            player.weapon_damage = 0;
            player.head_Defense = 0;
            player.gloves_Defense = 0;
            player.clothes_Defense = 0;
            player.shoe_Defense = 0;
            player.trousers_Defense = 0;
            player.skill_1_level = 1;
            player.skill_2_level = 1;
            player.skill_3_level = 1; player.skill_4_level = 1; setfalse();
        }
        if (character_play.i == 4)
        {
            player.jobname = "gunman";
            player.job_num = 4;
			player.skillpoint = 0;
            player.exp = 0;
            player.max_exp = 100;
            player.grow_exp = 100;

            player.money = 0;
            player.level = 1;

            player.HealthPoint = 150;
            player.Max_HealthPoint = 150;
            player.grow_Max_HealthPoint = 20;


            player.ManaPoint = 300;
            player.grow_ManaPoint = 20;
            player.Max_ManaPoint = 300;

            player.Defense = 30;
            player.grow_Defense = 3;
            
            player.attack_damage = 20;
            player.grow_attack_damage = 2;

            player.Natural_HP_reborn_amount = 5;
            player.grow_Natural_HP_reborn_amount = 1;
            player.Natural_MP_reborn_amount = 3;
            player.grow_Natural_MP_reborn_amount = 1;

            player.head_hp = 0;
            player.gloves_hp = 0;
            player.clothes_hp = 0;
            player.shoe_hp = 0;
            player.trousers_hp = 0;
            player.weapon_damage = 0;
            player.head_Defense = 0;
            player.gloves_Defense = 0;
            player.clothes_Defense = 0;
            player.shoe_Defense = 0;
            player.trousers_Defense = 0;
            player.skill_1_level = 1;
            player.skill_2_level = 1;
            player.skill_3_level = 1;   player.skill_4_level = 1;setfalse();
        }

    }
}
