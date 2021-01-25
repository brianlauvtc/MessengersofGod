using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mage_Skill3 : MonoBehaviour
{
   
    public GameObject player2;
    public Mage_skill_3 player_skill_3;
    public Text leveltext, damagetext, manatext;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 3)
        {
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_3 = player2.GetComponent<Mage_skill_3>();
            damagetext.text = "Bonus Damage : " + player_skill_3.main_damage_increase.ToString() + "\nHealth Point Reborn : " + player_skill_3.main_hp_reborn.ToString();
            leveltext.text = "Level : " + player_skill_3.skill_level.ToString();
            manatext.text = "Need Mana : " + player_skill_3.manause.ToString();
            
        }
    }
    

}
