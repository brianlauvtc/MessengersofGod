using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class warrior_Skill1 : MonoBehaviour
{

    public GameObject player2;
    public Warrior_skill_1 player_skill_1;
    public Text leveltext, damagetext, manatext;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 2)
        {
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_1 = player2.GetComponent<Warrior_skill_1>();
            damagetext.text = "Damage : " + player_skill_1.main_damage.ToString();
            leveltext.text = "Level : " + player_skill_1.skill_level.ToString();
            manatext.text = "Need Mana : " + player_skill_1.manause.ToString();
         
        }

    }
  

}
