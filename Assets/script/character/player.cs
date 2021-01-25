using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public static string scene_name;
    public static string player_name;
    public static string jobname;

    public static int job_num;    
    public static int money;
  
    public static int main_max_exp;
    public static int exp;
    public static int max_exp;
    public static int grow_exp;


    public static int skillpoint;
    public static int skill_1_level;
    public static int skill_2_level;
    public static int skill_3_level;
    public static int skill_4_level;

    public static float main_Max_HealthPoint;
    public static float main_ManaPoint;
    public static float main_Max_ManaPoint;
    public static float main_Defense;
    public static int main_attack_damage;
    public static float main_Natural_HP_reborn_amount;
    public static float main_Natural_MP_reborn_amount;

    public static int level;
    public static float grow_Max_HealthPoint;
 
    public static float grow_ManaPoint;
    public static float grow_Defense;
    public static int grow_attack_damage;
    public static float grow_Natural_HP_reborn_amount;
    public static float grow_Natural_MP_reborn_amount;

    public static float HealthPoint;
    public static float Max_HealthPoint;
    public static float Max_ManaPoint;
    public static float ManaPoint;

    public static float Defense;
    public static int attack_damage;
    public static float Natural_HP_reborn_amount;
    public static float Natural_MP_reborn_amount;

    public static int head_hp;
    public static int gloves_hp;
    public static int clothes_hp;
    public static int shoe_hp;
    public static int trousers_hp;
    public static int weapon_damage;

    public static float head_Defense;
    public static float gloves_Defense;
    public static float clothes_Defense;
    public static float shoe_Defense;
    public static float trousers_Defense;

    public static bool fighting_status;
    public static bool nom_fighting_status;
    public static bool dead;
    public static bool isdead;

    public static int count = 0;

    public static bool scenefire_m1;  public static bool scenefire_m1_finish;
    public static bool scenefire_m2;  public static int scenefire_m2_killcount;
    public static bool scenefire_m3;  public static int scenefire_m3_killcount;
    public static bool scenefire_m4;  public static int scenefire_m4_killcount;
    public static bool scenefire_m5;  public static int scenefire_m5_killcount;
    public static bool scenefire_m6;  public static int scenefire_m6_killcount; public static int scenefire_m6_killcount2;
 

    public static bool scenewater_m1; public static bool scenewater_m1_finish;
    public static bool scenewater_m2; public static int scenewater_m2_killcount;
    public static bool scenewater_m3; public static int scenewater_m3_killcount;
    public static bool scenewater_m4; public static int scenewater_m4_killcount;
    public static bool scenewater_m5; public static int scenewater_m5_killcount;
    public static bool scenewater_m6; public static int scenewater_m6_killcount; public static int scenewater_m6_killcount2;
   

    public static bool sceneearth_m1; public static bool sceneearth_m1_finish;
    public static bool sceneearth_m2; public static int sceneearth_m2_killcount;
    public static bool sceneearth_m3; public static int sceneearth_m3_killcount;
    public static bool sceneearth_m4; public static int sceneearth_m4_killcount;
    public static bool sceneearth_m5; public static int sceneearth_m5_killcount;
    public static bool sceneearth_m6; public static int sceneearth_m6_killcount; public static int sceneearth_m6_killcount2;
   

    public static bool sceneice_m1; public static bool sceneice_m1_finish;
    public static bool sceneice_m2; public static int sceneice_m2_killcount;
    public static bool sceneice_m3; public static int sceneice_m3_killcount;
    public static bool sceneice_m4; public static int sceneice_m4_killcount;
    public static bool sceneice_m5; public static int sceneice_m5_killcount;
    public static bool sceneice_m6; public static int sceneice_m6_killcount; public static int sceneice_m6_killcount2;



    public static bool scenefire_m1_accept;
    public static bool scenefire_m2_accept;
    public static bool scenefire_m3_accept;
    public static bool scenefire_m4_accept;
    public static bool scenefire_m5_accept;
    public static bool scenefire_m6_accept;
   

    public static bool scenewater_m1_accept;
    public static bool scenewater_m2_accept;
    public static bool scenewater_m3_accept;
    public static bool scenewater_m4_accept;
    public static bool scenewater_m5_accept;
    public static bool scenewater_m6_accept;
 

    public static bool sceneearth_m1_accept;
    public static bool sceneearth_m2_accept;
    public static bool sceneearth_m3_accept;
    public static bool sceneearth_m4_accept;
    public static bool sceneearth_m5_accept;
    public static bool sceneearth_m6_accept;
   

    public static bool sceneice_m1_accept;
    public static bool sceneice_m2_accept;
    public static bool sceneice_m3_accept;
    public static bool sceneice_m4_accept;
    public static bool sceneice_m5_accept;
    public static bool sceneice_m6_accept;

    public static bool fire_Crystal;
    public static bool water_Crystal;
    public static bool earth_Crystal;
    public static bool ice_Crystal;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
