using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooter_skill_3 : MonoBehaviour
{
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
    public GameObject enemy;
    public player_move pm;
    public player_status ps;
    public target_enemy target;
    public bool skillok;
    public Text notargettext; public Text notclosetext;
    public Text skilltext;
    public Text manatext;
    public Image Panel;
    GameObject player2;
    Animator animator;
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
        notargettext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().notargettext;
        target = player2.GetComponent<target_enemy>();
        enemy = target.target; notclosetext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().notclosetext;
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[2];
        Panel.fillAmount = cd_count / cd;
        main_damage = basic_damage + (skill_level - 1) * grow_damage + ((player.main_attack_damage / 10) * attack_damage_bonus);


        if (Input.GetKeyDown(KeyCode.E) && cd_count > 0 && ps.ss == skillState.no && animator.GetBool("attack") == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.Q))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().cd_count = 2;
                skilltext.text = skillname + " is not ready for use. ";
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint < manause)
        {
            if (Input.GetKeyDown(KeyCode.E) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.Q))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manacd_count = 2;
                manatext.text = "You have no enough manapoint to use " + skillname;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && cd_count <= 0 && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint >= manause && player.HealthPoint > 0)
        {
            if (Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.R))
            {
                if (enemy == null)
                {
                    GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().target_count = 2;
                    notargettext.text = "You don't have select a target enemy!";
                }
                else if(enemy != null && Vector3.Distance(transform.position, enemy.transform.position) > 5)
                {

                    GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().close_count = 2;
                    notclosetext.text = "The enemy is too far to you!";
                }
                else
                {
            
                    skillsound.Play();
         
                    player.count = 0;
      
                    player.nom_fighting_status = false;
                 
                    player.fighting_status = true;
                    
                    skillsound.Play();
             
                    pm.allowwalk = false;
              
                    player.ManaPoint -= manause;
               
                    ps.ss = skillState.skill3;
                  
                    animator.SetBool("run", false);
                  
                    animator.SetBool("walk", false);
                  
                    animator.SetBool("skill2", false);
                    
                    animator.SetBool("skill3", true);
                  
                    animator.SetBool("skill4", false);
                
                    animator.SetBool("skill1", false); cd_count = cd;  StartCoroutine(animatorcancel());  StartCoroutine(allowwalk());
                    StartCoroutine(damage());
                    player2.transform.LookAt(enemy.transform);
                }
            }
        }
        if (skillok == true)
        { check(); }
    }

    public void check()
    {
        //检测扇形角度
        enemy.GetComponent<Monster_Character_Attribute>().get_damage(main_damage);
        skillok = false;
    }
    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(0.8f);  
        animator.SetBool("skill3", false); 

    }
    IEnumerator damage()
    {
        yield return new WaitForSeconds(0.5f);
        skillok = true;
    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(1.017f);
        ps.ss = skillState.no;
        pm.allowwalk = true;
        skillsound.Stop(); 

    }
}
