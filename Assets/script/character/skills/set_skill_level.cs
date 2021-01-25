using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_skill_level : MonoBehaviour
{
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
