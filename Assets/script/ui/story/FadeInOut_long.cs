using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EZCameraShake;
public class FadeInOut_long : MonoBehaviour
{   
    public GameObject building;
    public GameObject Explosions;
    public GameObject asteroid;
    public GameObject[] people = new GameObject[10];
    public GameObject[] crystal = new GameObject[4];
    public GameObject[] boss = new GameObject[4];
    public GameObject[] crystal_new_pos = new GameObject[4];
    public NPC_Dead[] nd = new NPC_Dead[9];
    public CameraShake cameraShake;
    public bool ex;
    public MoveX mx;
    float time;
    float show_time;
    bool In;
    public NPC_Dead npc_dead;
    public FishMan_idle fish;
    bool Out;
    public int count;
    public int count_show;
    public int current;
    string[] dialogue = new string[21];
    int[] second_per_show = new int[21];
     int[] second = new int[21];
    public CanvasGroup cg;
  //  public CanvasGroup black_cg;
    public Text uitext;
    bool call;
    bool call_show;
    bool done;
    public change_skyboard skyboard_script;
    public GameObject[] player = new GameObject[3];
    public Color textcolor;
    public GameObject[] threeTofour = new GameObject[2];
    public GameObject[] fourTofive = new GameObject[2];
    public GameObject[] fiveTosix = new GameObject[2];
    public GameObject[] sixToseven = new GameObject[2];
    public GameObject[] sevenToeight = new GameObject[2];
    public GameObject[] oneoneToonetwo = new GameObject[2];
    public GameObject[] onetwoToonethree = new GameObject[2];
    public GameObject[] onethreeToonefour = new GameObject[2];
    public GameObject[] onefiveToonesix= new GameObject[3];
    public GameObject[] onesevenTooneeight = new GameObject[2];
    public GameObject[] onenineTotwoO = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        textcolor = uitext.color;
        done = true;
        count = 0;
        current = 0;
        dialogue[0] = "A long time ago";    
        dialogue[1] = "A planet called Pluto was born in this grand universe";
        dialogue[2] = "A god named Anaki used the power of water, fire, terra and ice to create Shengwang Town.";
        dialogue[3] = "The people in Pluto will live freely in the Shengwang Town.";
        dialogue[4] = "Some people are selling goods";
        dialogue[5] = "Some people are playing";
        dialogue[6] = "They live very happy";
        dialogue[7] = "Anaki built the temple in the Shengwang Town";
        dialogue[8] = "The temple is surrounded by four elemental crystals, which are water, fire, terra and ice.";
        dialogue[9] = "Which are the four elements used in the construction of Shengwang Town";
        dialogue[10] = "The four-element crystal could not be separated.";
        dialogue[11] = "Once separated, the planet would be in chaos.";
        dialogue[12] = "Two years later, a giant meteorite fell on Pluto.";
        dialogue[13] = "This meteorite caused a big bang and a big earthquake.";
        dialogue[14] = "Because the town was built with high technology";
        dialogue[15] = "The buildings here were not damaged by the explosion and the earthquake.";
        dialogue[16] = "But the impact of the explosion kept the four crystals away from their original positions.";
        dialogue[17] = "Because of the crystal separated, the crystal become a big monster to wreak havoc.";
        dialogue[18] = "Shengwang Town sent a lot of soldiers to fight the big monsters";
        dialogue[19] = "But the big monsters summon some little monster to killing soldiers";
        dialogue[20] = "Anaki is selecting one of hero to go to Pluto to solve the problem.";
      

        second_per_show[0] = 0;
        second_per_show[1] = 0;
        second_per_show[2] = 0;
        second_per_show[3] = 0;
        second_per_show[4] = 0;
        second_per_show[5] = 0;
        second_per_show[6] = 0;
        second_per_show[7] = 0;
        second_per_show[8] = 0;
        second_per_show[9] = 0;
        second_per_show[10] = 0;
        second_per_show[11] = 0;
        second_per_show[12] = 0;
        second_per_show[13] = 2;
        second_per_show[14] = 0;
        second_per_show[15] = 0;
        second_per_show[16] = 0;
        second_per_show[17] = 0;
        second_per_show[18] = 0;
        second_per_show[19] = 0;
        second_per_show[20] = 0;
       

        second[0] = 5;
        second[1] = 5;
        second[2] = 5;
        second[3] = 5;
        second[4] = 5;
        second[5] = 5;
        second[6] = 5;
        second[7] = 5;
        second[8] = 5;
        second[9] = 5;
        second[10] = 5;
        second[11] = 5;
        second[12] = 5;
        second[13] = 3;
        second[14] = 5;
        second[15] = 5;
        second[16] = 6;
        second[17] = 6;
        second[18] = 5;
        second[19] = 4;
        second[20] = 4;
     

    }

    // Update is called once per frame
    void Update()
    {
         if (current +2 == dialogue.Length)
        { uitext.text = ""; }
        else
        { uitext.text = dialogue[current]; }
        time = Time.deltaTime;
        show_time = Time.deltaTime;

        if (count_show == second_per_show[current])
        {
            done = true;
        }
        if (count < second[current] && Out == false && count_show == second_per_show[current] && done == true)
        {
            call_show = false;
            if (cg.alpha < 1)
                cg.alpha += time;
            if (cg.alpha >= 1 && In == false)
            {
                cg.alpha = 1;
                In = true;
                if (count < second[current] && call == false)
                {
                    call = true;
                    Invoke("add", 1.0f);
                }
            }
        }
        else if (count_show < second_per_show[current] && call_show == false)
        {
            done = false;
            call_show = true;
            Invoke("add_show", 1.0f);
        }
        if (count == second[current])
        {
            Out = true;            
            if (cg.alpha > 0)
                cg.alpha -= time;
            if (cg.alpha <= 0)
            {
                cg.alpha = 0;
                count = 0;
                count_show = 0;
                show_time = 0;
                In = false;
                Out = false;
                call = false;
                if (current < dialogue.Length - 1)
                {
                    current++;
                    if (current == 3)
                    {
                        uitext.color = Color.black;
                        skyboard_script.change_sky();
                        skyboard_script.change();
                    }

                    if (current == 4)
                    {
                        skyboard_script.cam1 = threeTofour[0];
                        skyboard_script.cam2 = threeTofour[1];
                        skyboard_script.change();
                    }

                    if (current == 5)
                    {
                        skyboard_script.cam1 = fourTofive[0];
                        skyboard_script.cam2 = fourTofive[1];
                        skyboard_script.change();
                    }
                    if (current == 6)
                    {
                        print("1");
                        skyboard_script.cam1 = fiveTosix[0];
                        skyboard_script.cam2 = fiveTosix[1];
                        skyboard_script.change();
                    }
                    if (current == 7)
                    {
                        building.SetActive(true);
                        skyboard_script.cam1 = sixToseven[0];
                        skyboard_script.cam2 = sixToseven[1];
                        skyboard_script.change();
                    }
                    if (current == 8)
                    {
                       
                        skyboard_script.cam1 = sevenToeight[0];
                        skyboard_script.cam2 = sevenToeight[1];
                        skyboard_script.change();
                    }
                    if (current == 12)
                    {
                        uitext.color = textcolor;
                        building.SetActive(false);
                        skyboard_script.cam1 = oneoneToonetwo[0];
                        skyboard_script.cam2 = oneoneToonetwo[1];
                        skyboard_script.change();
                        skyboard_script.change_old_sky();
                        mx.speed = 700;
                    }
                    if (current == 13)
                    {
                        uitext.color = Color.black;
                        building.SetActive(true);
                        skyboard_script.cam1 = onetwoToonethree[0];
                        skyboard_script.cam2 = onetwoToonethree[1];
                       
                        skyboard_script.change();
                        skyboard_script.change_sky();
                        mx.speed = 1200;
                    }
                    if (current == 14)
                    {
                        building.SetActive(false);
                        skyboard_script.cam1 = onethreeToonefour[0];
                        skyboard_script.cam2 = onethreeToonefour[1];
                  
                        skyboard_script.change();

                    }
                    if (current == 16)
                    {

                        skyboard_script.cam1 = onefiveToonesix[0];
                        skyboard_script.cam2 = onefiveToonesix[1];
                        onefiveToonesix[2].SetActive(false);
                        skyboard_script.change();

                        skyboard_script.change_normal_sky();
                    }
                    if (current == 17)
                    {

                        for (int i = 0; i < 4; i++)
                        {
                          //  crystal_new_pos[i].SetActive(false);
                           // boss[i].SetActive(true);

                        }
                        for (int ig = 0; ig < 9; ig++)
                        { nd[ig].set_always_dead(); }
                    }
                    if (current == 18)
                    {

                        skyboard_script.cam1 = onesevenTooneeight[0];
                        skyboard_script.cam2 = onesevenTooneeight[1];
                        skyboard_script.change();


                    }
                    if (current == 19)
                    {

                        Invoke("setDead_on", 3f);
                        Invoke("setidle_on", 3.2f);


                    }
                    if (current == 20)
                    {

                        skyboard_script.cam1 = onenineTotwoO[0];
                        skyboard_script.cam2 = onenineTotwoO[1];
                        onenineTotwoO[2].SetActive(true);
                        for (int ig = 0; ig < 3; ig++)
                        { player[ig].SetActive(true); }
                        skyboard_script.change();
                        asteroid.SetActive(false);

                    }
                }
                else { Application.LoadLevel("main_Scene"); }
            }
        }

    }

    public void add()
    {
        count++;
        if (count < second[current])
        { Invoke("add", 1.0f); }
    }
    public void add_show()
    {
        count_show++;
        if (count_show < second_per_show[current])
        {  Invoke("add_show", 1.0f); }
    }

    public void setDead_on()
    {
        npc_dead.setDead();
       
    }
    public void setidle_on()
    {
        fish.setIdle();
    }
    public void explo()
    {
        if (ex == false)
        {
            //  skyboard_script.cam1 = onethreeToonefour[0];
            //  skyboard_script.cam2 = onethreeToonefour[1];
            // skyboard_script.change();
            StartCoroutine(dissappear());
            Explosions.SetActive(true);
            CameraShaker.Instance.ShakeOnce(8f, 8f, 4f, 4f);
            //StartCoroutine(cameraShake.Shake(.15f, .4f));
            ex = true; }
    }

    IEnumerator dissappear()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 4; i++)
        {

            //crystal[i].gameObject.transform.position = crystal_new_pos[i].gameObject.transform.position;
            crystal[i].SetActive(false);
        }
        for (int i = 0; i < 10; i++)
        {
            people[i].SetActive(false);
        }
    }
}
