using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tp_script_earth : MonoBehaviour
{
   
    public hotkeylist hkl;
    public Inventory inventory;
    public personalarmor p;
    Camera main_camera;
    public levelLoader Loader;
    public Ray ray;
    public GameObject player2;
    public GameObject ESCcanvas;
    public AudioSource tpsound;
    public closecanvas cc;
    public GameObject TPcanvas;
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


    public GameObject missionmanager;

     fire_mission2 fm2;
     fire_mission3 fm3;
     fire_mission4 fm4;
     fire_mission5 fm5;
     fire_mission6 fm6;

    earth_mission2 em2;
    earth_mission3 em3;
    earth_mission4 em4;
    earth_mission5 em5;
    earth_mission6 em6;

    water_mission2 wm2;
    water_mission3 wm3;
    water_mission4 wm4;
    water_mission5 wm5;
    water_mission6 wm6;

    ice_mission2 im2;
    ice_mission3 im3;
    ice_mission4 im4;
    ice_mission5 im5;
    ice_mission6 im6;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        main_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        player2 = GameObject.FindGameObjectWithTag("Player");

        if (player.jobname == "shooter")
        {
            ss1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_1>();
            ss2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_2>();
            ss3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_3>();
            ss4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooter_skill_4>();
            player.skill_1_level = ss1.skill_level;
            player.skill_2_level = ss2.skill_level;
            player.skill_3_level = ss3.skill_level;
            player.skill_4_level = ss4.skill_level;
        }
        if (player.jobname == "warrior")
        {
            ws1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_1>();
            ws2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_2>();
            ws3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_3>();
            ws4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Warrior_skill_4>();
            player.skill_1_level = ws1.skill_level;
            player.skill_2_level = ws2.skill_level;
            player.skill_3_level = ws3.skill_level;
            player.skill_4_level = ws4.skill_level;
        }
        if (player.jobname == "mage")
        {
            ms1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_1>();
            ms2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_2>();
            ms3 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_3>();
            ms4 = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage_skill_4>();
            player.skill_1_level = ms1.skill_level;
            player.skill_2_level =ms2.skill_level;
            player.skill_3_level = ms3.skill_level;
            player.skill_4_level = ms4.skill_level;
        }
        if (player.jobname == "gunman")
        {
            gs1 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_1>();
            gs2 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_2>();
            gs3 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_3>();
            gs4 = GameObject.FindGameObjectWithTag("Player").GetComponent<gunner_skill_4>();
             player.skill_1_level = gs1.skill_level ;
             player.skill_2_level = gs2.skill_level ;
             player.skill_3_level = gs3.skill_level ;
             player.skill_4_level = gs4.skill_level ;
        }

       
       
    }

    public void setcomponent()
    {
        if (SceneManager.GetActiveScene().name == "scenefire")
        {
            fm2 = missionmanager.GetComponent<fire_mission2>();
            fm3 = missionmanager.GetComponent<fire_mission3>();
            fm4 = missionmanager.GetComponent<fire_mission4>();
            fm5 = missionmanager.GetComponent<fire_mission5>();
            fm6 = missionmanager.GetComponent<fire_mission6>();
        }

        if (SceneManager.GetActiveScene().name == "sceneice")
        {
            im2 = missionmanager.GetComponent<ice_mission2>();
            im3 = missionmanager.GetComponent<ice_mission3>();
            im4 = missionmanager.GetComponent<ice_mission4>();
            im5 = missionmanager.GetComponent<ice_mission5>();
            im6 = missionmanager.GetComponent<ice_mission6>();
        }

        if (SceneManager.GetActiveScene().name == "sceneearth")
        {
            em2 = missionmanager.GetComponent<earth_mission2>();
            em3 = missionmanager.GetComponent<earth_mission3>();
            em4 = missionmanager.GetComponent<earth_mission4>();
            em5 = missionmanager.GetComponent<earth_mission5>();
            em6 = missionmanager.GetComponent<earth_mission6>();
        }

        if (SceneManager.GetActiveScene().name == "scenewater")
        {
            wm2 = missionmanager.GetComponent<water_mission2>();
            wm3 = missionmanager.GetComponent<water_mission3>();
            wm4 = missionmanager.GetComponent<water_mission4>();
            wm5 = missionmanager.GetComponent<water_mission5>();
            wm6 = missionmanager.GetComponent<water_mission6>();
        }

    }
    public void savemission()
    {
        if (SceneManager.GetActiveScene().name == "scenefire")
        {
            player.scenefire_m2_killcount = fm2.killcount;
            player.scenefire_m3_killcount = fm2.killcount;
            player.scenefire_m4_killcount = fm3.killcount;
            player.scenefire_m5_killcount = fm4.killcount;
            player.scenefire_m6_killcount = fm5.killcount;
            player.scenefire_m6_killcount2 = fm6.killcount2;
        }

        if (SceneManager.GetActiveScene().name == "scenewater")
        {
            player.scenewater_m2_killcount = wm2.killcount;
            player.scenewater_m3_killcount = wm2.killcount;
            player.scenewater_m4_killcount = wm3.killcount;
            player.scenewater_m5_killcount = wm4.killcount;
            player.scenewater_m6_killcount = wm5.killcount;
            player.scenewater_m6_killcount2 = wm6.killcount2;
        }

        if (SceneManager.GetActiveScene().name == "sceneice")
        {
            player.sceneice_m2_killcount = im2.killcount;
            player.sceneice_m3_killcount = im2.killcount;
            player.sceneice_m4_killcount = im3.killcount;
            player.sceneice_m5_killcount = im4.killcount;
            player.sceneice_m6_killcount = im5.killcount;
            player.sceneice_m6_killcount2 = im6.killcount2;
        }

        if (SceneManager.GetActiveScene().name == "sceneearth")
        {
            player.sceneearth_m2_killcount = em2.killcount;
            player.sceneearth_m3_killcount = em2.killcount;
            player.sceneearth_m4_killcount = em3.killcount;
            player.sceneearth_m5_killcount = em4.killcount;
            player.sceneearth_m6_killcount = em5.killcount;
            player.sceneearth_m6_killcount2 = em6.killcount2;
        }
    }

    public void start_tp()
    {
        cc.Detail.SetActive(false);
        for (int i = 0; i < cc.canvas.Length; i++)
        {
            cc.canvas[i].SetActive(false);
        }
        for (int i = 0; i < 5; i++)
        {
            static_hkl_inventory.item[i] = hkl.item[i];
            static_hkl_inventory.num[i] = hkl.num[i];
        }
        print("sceneearth");
        for (int i = 0; i < 21; i++)
        {
            static_hkl_inventory.items[i] = inventory.items[i];
            static_hkl_inventory.itemCount[i] = inventory.itemCount[i];
        }
        print("sceneearth");
        for (int i = 0; i < 6; i++)
        {
            static_hkl_inventory.armor[i] = p.armor[i];

        }
        print("sceneearth");
        setcomponent(); print("sceneearth");
        savemission();
        print("sceneearth");

        if (Loader == null)
                SceneManager.LoadScene("sceneearth");
            else
                Loader.LoadLevel("sceneearth");
        TPcanvas.SetActive(false);

    }
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        tpsound.Stop();
    }
}
