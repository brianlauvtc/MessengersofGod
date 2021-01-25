using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrior_skill_1 : MonoBehaviour {
    public string skillname;
    public string skilldescription;
    public int skill_level;    
    public int basic_damage;
    public int grow_damage;
    public int attack_damage_bonus;
    public int main_damage;
    public float manause;
    public int cd;
    private float cd_count;

    public player_status ps;
    public player_move pm;
   
    public bool[] target = new bool[29];
    public float[] distancea = new float[29];
    public float[] anglea = new float[29];
    public GameObject[] enemy = new GameObject[29];

    Animator animator;
    public GameObject skill;
    GameObject player2;
    public Image Panel;      
    public bool skillok;
    public Text manatext; 
    public AudioSource skillsound;
    public Text skilltext;
    // Use this for initialization
    public int getlevel()
    {
        return skill_level;
    }


    void Start()
    {
        player2 = GameObject.FindGameObjectWithTag("Player");
        pm = player2.GetComponent<player_move>();
        ps = player2.GetComponent<player_status>();
        animator = player2.GetComponent<Animator>();
        cd_count = 0;
        //InvokeRepeating("cold_cown", 1, 1);
    }

    public void cold_cown()
    {
        if (cd_count > 0)
        {
            cd_count--;
        }
    }

    void Update()
    {
     

        if (cd_count > 0)
        {
            cd_count -= 1*Time.deltaTime;
        }
    
        enemy = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().enemy;
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        manatext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manatext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[0];
        Panel.fillAmount = cd_count / cd;
        if (Input.GetKeyDown(KeyCode.Q) && cd_count > 0 && ps.ss == skillState.no && animator.GetBool("attack") == false  )
        {
            if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.R))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().cd_count = 2;
                skilltext.text = skillname + " is not ready for use. ";
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint < manause)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.R))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manacd_count = 2;
                manatext.text ="You have no enough manapoint to use " +skillname ;
            }
        }
        main_damage = basic_damage + (skill_level - 1) * grow_damage + ((player.main_attack_damage / 10) * attack_damage_bonus);
        if (Input.GetKeyDown(KeyCode.Q) && cd_count <= 0 &&   ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint >= manause && player.HealthPoint > 0)
        {
            if (Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.R) )
            {
                skillsound.Play();
                pm.allowwalk = false;
                player.ManaPoint -= manause;
                ps.ss = skillState.skill1;
                animator.SetBool("walk", false);
                animator.SetBool("run", false);
                animator.SetBool("skill2", false);
                animator.SetBool("skill3", false);
                animator.SetBool("skill4", false); 
                animator.SetBool("skill1", true); cd_count = cd; StartCoroutine(damage()); StartCoroutine(animatorcancel()); StartCoroutine(stopattack()); StartCoroutine(allowwalk());
            }

                
        }
        if (skillok == true)
        { check(); }

    }
    public void check()
    {

        //检测扇形角度



        for (int i = 0; i < enemy.Length; i++)
        {

            float distance = Vector3.Distance(enemy[i].transform.position, skill.transform.position);
            distancea[i] = distance;
          
            if (Vector3.Distance(enemy[i].transform.position, skill.transform.position) < 2.5f)
            {
                player.count = 0;
                player.nom_fighting_status = false;
                player.fighting_status = true;
                if (target[i] == false)
                {
                    target[i] = true;
                    enemy[i].GetComponent<Monster_Character_Attribute>().get_damage(main_damage);


                }
                

            }



        }

    }

    IEnumerator stopattack()
    {
        yield return new WaitForSeconds(3.5f);
        skillok = false;
        for (int i = 0; i < 29; i++)
        {
            target[i] = false;
        }
    }
    IEnumerator damage()
    {
        yield return new WaitForSeconds(1.6f);
        skillok = true;
    }

    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(1.0f);
        animator.SetBool("skill1", false); 

    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(3.7f);
        skillsound.Stop();
        ps.ss = skillState.no;
        pm.allowwalk = true;

        for (int i = 0; i < 29; i++)
        {
            target[i] = false;
        }
    }

}
