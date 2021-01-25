
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class target_enemy : MonoBehaviour
{
    public AudioSource boss;
    public AudioSource monster;
    public bool bosssound, monstersound;
    public GameObject target;
    public monster_spawner[] enemy;
    public GameObject[] hp_bar = new GameObject[30];
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("bossbgm").GetComponent<AudioSource>();
        monster = GameObject.FindGameObjectWithTag("monsterbgm").GetComponent<AudioSource>();
        hp_bar = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().hp_bar;
        enemy = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().spawnpoint;
    }

    public void monster1_0_1_2_3_13_14_15()
    {
        if (target.gameObject.name == "Chickena" || target.gameObject.name == "waterspirita" || target.gameObject.name == "Cactusa" || target.gameObject.name == "IceGoblinc")
        {
            int b = 0;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Chickenb" || target.gameObject.name == "waterspiritb" || target.gameObject.name == "Cactusb" || target.gameObject.name == "IceGoblinb")
        {
            int b = 1;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }


        }
        if (target.gameObject.name == "Chickenc" || target.gameObject.name == "waterspiritc" || target.gameObject.name == "Cactusc" || target.gameObject.name == "IceGoblinc")
        {
            int b = 2;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }

        if (target.gameObject.name == "Chickend" || target.gameObject.name == "waterspiritd" || target.gameObject.name == "Cactusd" || target.gameObject.name == "IceGoblind")
        {
            int b = 3;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Chickene" || target.gameObject.name == "waterspirite" || target.gameObject.name == "Cactuse" || target.gameObject.name == "IceGobline")
        {
            int b = 13;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Chickenf" || target.gameObject.name == "waterspiritf" || target.gameObject.name == "Cactusf" || target.gameObject.name == "IceGoblinf")
        {
            int b = 14;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Chickeng" || target.gameObject.name == "waterspiritg" || target.gameObject.name == "Cactusg" || target.gameObject.name == "IceGobling")
        {
            int b = 15;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }

    }



    public void monster2_4_5_6_7_16_17_18()
    {
        if (target.gameObject.name == "Lava Guarda" || target.gameObject.name == "waterghosta" || target.gameObject.name == "Green Devia" || target.gameObject.name == "iceguarda")
        {
            int b = 4;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Lava Guardb" || target.gameObject.name == "waterghostb" || target.gameObject.name == "Green Devib" || target.gameObject.name == "iceguardb")
        {
            int b = 5;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Lava Guardc" || target.gameObject.name == "waterghostc" || target.gameObject.name == "Green Devic" || target.gameObject.name == "iceguardc")
        {
            int b = 6;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Lava Guardd" || target.gameObject.name == "waterghostd" || target.gameObject.name == "Green Devid" || target.gameObject.name == "iceguardd")
        {

            int b = 7;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Lava Guarde" || target.gameObject.name == "waterghoste" || target.gameObject.name == "Green Devie" || target.gameObject.name == "iceguarde")
        {
            int b = 16;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Lava Guardf" || target.gameObject.name == "waterghostf" || target.gameObject.name == "Green Devif" || target.gameObject.name == "iceguardf")
        {
            int b = 17;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Lava Guardg" || target.gameObject.name == "waterghostg" || target.gameObject.name == "Green Devig" || target.gameObject.name == "iceguardg")
        {

            int b = 18;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
    }



    public void monster3_8_9_10_11_19_20_21()
    {
        if (target.gameObject.name == "Fire Mana" || target.gameObject.name == "waterailena" || target.gameObject.name == "zombiegirla" || target.gameObject.name == "mutante")
        {
            int b = 8;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Fire Manb" || target.gameObject.name == "waterailenb" || target.gameObject.name == "zombiegirlb" || target.gameObject.name == "mutantb")
        {
            int b = 9;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "Fire Manc" || target.gameObject.name == "waterailenc" || target.gameObject.name == "zombiegirlc" || target.gameObject.name == "mutantc")
        {
            int b = 10;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Fire Mand" || target.gameObject.name == "waterailend" || target.gameObject.name == "zombiegirld" || target.gameObject.name == "mutantd")
        {
            int b = 11;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }


        }
        if (target.gameObject.name == "Fire Mane" || target.gameObject.name == "waterailene" || target.gameObject.name == "zombiegirle" || target.gameObject.name == "mutante")
        {

            int b = 19;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Fire Manf" || target.gameObject.name == "waterailenf" || target.gameObject.name == "zombiegirlf" || target.gameObject.name == "mutantf")
        {

            int b = 20;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Fire Mang" || target.gameObject.name == "wateraileng" || target.gameObject.name == "zombiegirlg" || target.gameObject.name == "mutantg")
        {

            int b = 21;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
    }



    public void monster4_22_23_24_25_26_27_28()
    {
        if (target.gameObject.name == "girla" || target.gameObject.name == "FishMana" || target.gameObject.name == "goblina" || target.gameObject.name == "Demona")
        {
            int b = 22;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }


        }
        if (target.gameObject.name == "girlb" || target.gameObject.name == "FishManb" || target.gameObject.name == "goblinb" || target.gameObject.name == "Demonb")
        {
            int b = 23;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "girlc" || target.gameObject.name == "FishManc" || target.gameObject.name == "goblinc" || target.gameObject.name == "Demonc")
        {
            int b = 24;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "girld" || target.gameObject.name == "FishMand" || target.gameObject.name == "goblind" || target.gameObject.name == "Demond")
        {

            int b = 25;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "girle" || target.gameObject.name == "FishMane" || target.gameObject.name == "gobline" || target.gameObject.name == "Demone")
        {
            int b = 26;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }
        }
        if (target.gameObject.name == "girlf" || target.gameObject.name == "FishManf" || target.gameObject.name == "goblinf" || target.gameObject.name == "Demonf")
        {
            int b = 27;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "girlg" || target.gameObject.name == "FishMang" || target.gameObject.name == "gobling" || target.gameObject.name == "Demong")
        {
            int b = 28;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
    }



    public void monsterboss_12_29()
    {
        if (target.gameObject.name == "bull_king" || target.gameObject.name == "WaterCow" || target.gameObject.name == "Bull Demon King" || target.gameObject.name == "IceWizard")
        {
            int b = 12;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
        if (target.gameObject.name == "Crystal")
        {
            int b =29;
            for (int a = 0; a < 30; a++)
            {
                if (a == b)
                { hp_bar[a].gameObject.SetActive(true); }
                else { hp_bar[a].gameObject.SetActive(false); }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            monster1_0_1_2_3_13_14_15();
            monster2_4_5_6_7_16_17_18();
            monster3_8_9_10_11_19_20_21();
            monster4_22_23_24_25_26_27_28();
            monsterboss_12_29();
        }

        if (enemy[12].getdamage == true && bosssound == false)

        {
            bosssound = true;
            monstersound = false;
            boss.Play();
            monster.Stop();
        }
        if (enemy[12].getdamage == false && monstersound == false)
        {
            bosssound = false;
            monstersound = true;
            monster.Play();
            boss.Stop();
        }
        if (target == null)
        {
            hp_bar[0].gameObject.SetActive(false);
            hp_bar[1].gameObject.SetActive(false);
            hp_bar[2].gameObject.SetActive(false);
            hp_bar[3].gameObject.SetActive(false);
            hp_bar[4].gameObject.SetActive(false);
            hp_bar[5].gameObject.SetActive(false);
            hp_bar[6].gameObject.SetActive(false);
            hp_bar[7].gameObject.SetActive(false);
            hp_bar[8].gameObject.SetActive(false);
            hp_bar[9].gameObject.SetActive(false);
            hp_bar[10].gameObject.SetActive(false);
            hp_bar[11].gameObject.SetActive(false);
            hp_bar[12].gameObject.SetActive(false);
            hp_bar[13].gameObject.SetActive(false);
            hp_bar[14].gameObject.SetActive(false);
            hp_bar[15].gameObject.SetActive(false);
            hp_bar[16].gameObject.SetActive(false);
            hp_bar[17].gameObject.SetActive(false);
            hp_bar[18].gameObject.SetActive(false);
            hp_bar[19].gameObject.SetActive(false);
            hp_bar[20].gameObject.SetActive(false);
            hp_bar[21].gameObject.SetActive(false);
            hp_bar[22].gameObject.SetActive(false);
            hp_bar[23].gameObject.SetActive(false);
            hp_bar[24].gameObject.SetActive(false);
            hp_bar[25].gameObject.SetActive(false);
            hp_bar[26].gameObject.SetActive(false);
            hp_bar[27].gameObject.SetActive(false);
            hp_bar[28].gameObject.SetActive(false);
            hp_bar[29].gameObject.SetActive(false);
        }



        if (target != null)
        {
            if (target.gameObject.name != "Crystal")
            {
                if (target.GetComponent<Monster_Character_Attribute>().HealthPoint <= 0)
                {
                    target = null;
                }




            }


            if (target.gameObject.name == "Crystal")
            {
                if (target.GetComponent<crystal_Character_Attribute>().HealthPoint <= 0)
                {
                    target = null;
                }

            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                target = null;
            }
        }
    }
    public void settarget(GameObject tr)
    {
        target = tr;
    }

}
