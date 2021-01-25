using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunner_Skill4 : MonoBehaviour
{
     bool t;
    public GameObject player2;
    public gunner_skill_4 player_skill_4;
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
            player_skill_4 = player2.GetComponent<gunner_skill_4>();
            damagetext.text = "Damage : " + player_skill_4.main_damage.ToString();
            leveltext.text = "Level : " + player_skill_4.skill_level.ToString();
             manatext.text = "Need Mana : " + player_skill_4.manause.ToString();
            
        }
    }
   

}
