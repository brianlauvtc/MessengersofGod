using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mage_skill_3 : MonoBehaviour {
    public string skillname;
    public string skilldescription;

  
    public int skill_level;
    
    public int main_damage_increase;
    public int damage_increase;
    public int grow_damage_increase;

    public int main_hp_reborn;
    public int hp_reborn;
    public int grow_hp_reborn;

    public int buff_time;
    public float buff_time_count;
    public int count;
    public int cd;
    private float cd_count;

    public player_move pm;
    public player_status ps;
    GameObject player2;
    Animator animator;
    public AudioSource skillsound;
    public float manause;
    public bool skillok;
    public Text skilltext;
    public Text manatext;
    public Image Panel;
    public bool buffer;
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
     
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[2];
        Panel.fillAmount = cd_count / cd;
        main_damage_increase = damage_increase + (skill_level - 1) * grow_damage_increase;
        main_hp_reborn = hp_reborn + (skill_level - 1) * grow_hp_reborn;

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
            if (Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.R))
            {
                skillsound.Play();
                pm.allowwalk = false;
                player.ManaPoint -= manause;
                ps.ss = skillState.skill3;
                animator.SetBool("run", false);
                animator.SetBool("walk", false);
                animator.SetBool("skill2", false);
                animator.SetBool("skill3", true);
                animator.SetBool("skill4", false);
                animator.SetBool("skill1", false); cd_count = cd; StartCoroutine(animatorcancel()); StartCoroutine(allowwalk());
                player.attack_damage += main_damage_increase;
                player.HealthPoint += main_hp_reborn;
                cd_count = cd;
                buff_time_count = buff_time;
                buffer = true;
                //  InvokeRepeating("buffer", 1, 1);

            }

        }
        if (buffer == true)
        {
            if (buff_time_count > 0)
            {
                buff_time_count -= Time.deltaTime;
                count++;
            }
            if (buff_time_count <= 0)
            {
                player.attack_damage -= main_damage_increase;
                buffer = false;
            }
        }

        
       
    }
    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("skill3", false);

    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(1.0f);
        ps.ss = skillState.no;
        pm.allowwalk = true;
        skillsound.Stop();
        
    }
}
