using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Character_Attribute : MonoBehaviour {
    public float grow_Max_HealthPoint;
    public float grow_Natural_MP_reborn_amount;
    public float Natural_MP_reborn_amount;
    public float Max_ManaPoint;
    public float grow_ManaPoint;
    public float grow_Defense;
    public int grow_attack_damage;
    public float grow_Natural_HP_reborn_amount;
    public float HealthPoint;
    public float Max_HealthPoint;
    public float ManaPoint;
    public float Defense;
    public int attack_damage;
    public float Natural_HP_reborn_amount;
    public float speed;
    
    public float level;
    public int main_max_exp;
    public int exp;
    public int max_exp;
    public int grow_exp;
    public int money;
    public int skillpoint;

    public bool fighting;
    public bool nom_fighting;
    public bool dead;
    public int count2 = 0;

    private GameObject monster;
    private Monster_Character_Attribute monster_attribute_script;

    // Use this for initialization
    void Start() {
        
        player.fighting_status = false;
        player.nom_fighting_status = true;
        InvokeRepeating("Natural_HP_reborn", 2, 2);
      
    

        InvokeRepeating("time_count", 1, 1);
    }

    private void Natural_HP_reborn()
    {
        if (HealthPoint < Max_HealthPoint && nom_fighting== true && fighting == false&& dead == false)
        {
            player.HealthPoint += player.main_Natural_HP_reborn_amount;
        }
        if (HealthPoint < Max_HealthPoint && nom_fighting == false && fighting  == true&& dead == false)
        {
            player.HealthPoint += 2;
        }
        if (ManaPoint < Max_ManaPoint && nom_fighting  == true&& fighting == false && dead == false)
        {
            player.ManaPoint += player.main_Natural_MP_reborn_amount;
        }
        if (ManaPoint < Max_ManaPoint && nom_fighting == false && fighting == true && dead == false)
        {
            player.ManaPoint += 2;
        }

    }

    public  void get_damage(float damage)
    {

        player.HealthPoint -= Mathf.Round(damage * (1 - player.main_Defense / 1000));
        player.fighting_status = true;
        player.nom_fighting_status = false;
        player.count = 0;

    }

    // Update is called once per frame
    

    void Update() {


        skillpoint = player.skillpoint;
        player.main_attack_damage = player.attack_damage + player.weapon_damage + (player.grow_attack_damage * (player.level - 1));
        player.main_Defense = player.Defense + player.gloves_Defense + player.clothes_Defense + player.trousers_Defense + player.head_Defense + player.shoe_Defense + (player.grow_Defense * (player.level - 1));
        player.main_Max_HealthPoint = player.Max_HealthPoint + player.gloves_hp + player.clothes_hp + player.trousers_hp + player.head_hp + player.shoe_hp + (player.grow_Max_HealthPoint * (player.level - 1));
        player.main_Max_ManaPoint = player.Max_ManaPoint + (player.grow_ManaPoint * (player.level - 1f));
        player.main_Natural_HP_reborn_amount = player.Natural_HP_reborn_amount + (player.grow_Natural_HP_reborn_amount*(player.level-1));
        player.main_Natural_MP_reborn_amount = player.Natural_MP_reborn_amount + (player.grow_Natural_MP_reborn_amount * (player.level - 1));

        player.main_max_exp = player.max_exp + (player.level - 1) * player.grow_exp;
        dead = player.dead;
        main_max_exp = player.main_max_exp;
        exp = player.exp;
        max_exp = player.max_exp;
        grow_exp = player.grow_exp;
        grow_Max_HealthPoint = player.grow_Max_HealthPoint;
        grow_ManaPoint = player.grow_ManaPoint;
        grow_Defense = player.grow_Defense;
        grow_attack_damage = player.grow_attack_damage;
        grow_Natural_MP_reborn_amount = player.grow_Natural_MP_reborn_amount;
        grow_Natural_HP_reborn_amount = player.grow_Natural_HP_reborn_amount;
        level = player.level;
        count2 = player.count;
        fighting = player.fighting_status;
        HealthPoint = player.HealthPoint;
        nom_fighting = player.nom_fighting_status;
        Max_HealthPoint = player.main_Max_HealthPoint;
        Max_ManaPoint = player.main_Max_ManaPoint;
        ManaPoint = player.ManaPoint;
        Defense = player.main_Defense;
        attack_damage = player.main_attack_damage;
        Natural_HP_reborn_amount = player.main_Natural_HP_reborn_amount;
        Natural_MP_reborn_amount = player.main_Natural_MP_reborn_amount;
        money = player.money;

        
    }

    public void time_count()
    {
        player.count++;
    }


  
  


      
  
      
}
