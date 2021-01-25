using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunner_Skill3 : MonoBehaviour
{
     bool t;
    public GameObject player2;
    public gunner_skill_3 player_skill_3;
    public Text leveltext, damagetext, manatext;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 4)
        {
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_3 = player2.GetComponent<gunner_skill_3>();
            damagetext.text = "Bonus Damage : " + player_skill_3.main_damage_increase.ToString() + "\nMana Point Reborn : " + player_skill_3.main_mp_reborn.ToString();
            leveltext.text = "Level : " + player_skill_3.skill_level.ToString();
           manatext.text = "Need Mana : " + player_skill_3.manause.ToString();

           
        }
    }
    

}
