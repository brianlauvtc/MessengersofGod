using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrior_skill_2 : MonoBehaviour {
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

    public AudioSource skillsound;
   
    public player_status ps;
    public player_move pm;

  
   
    public bool[] target = new bool[29];
    public float[] distancea = new float[29];
    public float[] anglea = new float[29];
    public GameObject[] enemy = new GameObject[29];

    Animator animator;
    GameObject player2;
    public Image Panel;    
    public Text manatext; 
    public Vector3 num;
    public Text skilltext;
    public int getlevel()
    {
        return skill_level;
    }
    // Use this for initialization
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
            cd_count -= 1 * Time.deltaTime;
        }
        manatext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manatext;
        enemy = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().enemy;
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[1];
        Panel.fillAmount = cd_count / cd;
        main_damage = basic_damage + (skill_level - 1) * grow_damage + ((player.main_attack_damage / 10) * attack_damage_bonus);
        if (Input.GetKeyDown(KeyCode.W) && cd_count > 0 && ps.ss ==skillState.no  && animator.GetBool("attack") == false  )
        {
            if (Input.GetKeyDown(KeyCode.W) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Q))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().cd_count = 2;
                skilltext.text = skillname + " is not ready for use. ";
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint < manause)
        {
            if (Input.GetKeyDown(KeyCode.W) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Q))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manacd_count = 2;
                manatext.text = "You have no enough manapoint to use " + skillname;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && cd_count <= 0 && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint >= manause && player.HealthPoint > 0)
        {
            if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.R))
            {
                skillsound.Play();
                pm.allowwalk = false;
                player.ManaPoint -= manause;
                ps.ss = skillState.skill2;
                animator.SetBool("run", false);
                animator.SetBool("walk", false);
                animator.SetBool("skill2", true);
                animator.SetBool("skill3", false); 
                animator.SetBool("skill4", false);
                animator.SetBool("skill1", false); cd_count = cd; StartCoroutine(animatorcancel()); StartCoroutine(allowwalk());






            }
           
        }

        if (animator.GetBool("skill2") == true)
        { check(); }

    }
    public void check() {

        //检测扇形角度



        //检测扇形角度
        for (int i = 0; i < enemy.Length; i++)
        {

            //检测扇形角度
            //与敌人的距离
            float distance = Vector3.Distance(transform.position, enemy[i].transform.position);
            //玩家正前方的向量
            Vector3 norVec = transform.rotation * Vector3.forward;
            //玩家与敌人的方向向量
            Vector3 temVec = enemy[i].transform.position - transform.position;
            //求两个向量的夹角
            float jiajiao = Mathf.Acos(Vector3.Dot(norVec.normalized, temVec.normalized)) * Mathf.Rad2Deg;
            if (distance < 3.0)
            {
                if (jiajiao <= 60 * 0.5f)
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



    }
        
        

   
    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(1.0f);
        animator.SetBool("skill2", false); 

    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(2.2f);
        ps.ss = skillState.no;
        pm.allowwalk = true;
        skillsound.Stop();
        for (int i = 0; i < 29; i++)
        {
            target[i] = false;
        }
    }
}
