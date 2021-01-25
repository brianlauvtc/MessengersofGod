using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunner_skill_2 : MonoBehaviour {
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
    public GameObject enemy;
    public AudioSource skillsound;
    public target_enemy target;
    public player_move pm;
    public player_status ps;

    public bool skillok;
    public Text skilltext;
    public Text manatext;
    public Text notclosetext;
    public Text notargettext;

    public Image Panel;
    GameObject player2;
    Animator animator;
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
    }

    // Update is called once per frame
    
    void Update()
    {
        if (cd_count > 0)
        {
            cd_count -= 1 * Time.deltaTime;
        }
        target = player2.GetComponent<target_enemy>();
        enemy = target.target;
        manatext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manatext; notclosetext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().notclosetext;
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        notargettext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().notargettext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[1];
        Panel.fillAmount = cd_count / cd;
        main_damage = basic_damage + (skill_level - 1) * grow_damage + ((player.main_attack_damage / 10) * attack_damage_bonus);

        if (Input.GetKeyDown(KeyCode.W) && cd_count > 0 && ps.ss == skillState.no && animator.GetBool("attack") == false)
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
                if (enemy == null)
                {
                    GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().target_count = 2;
                    notargettext.text = "You don't have select a target enemy!";
                }
                else if (enemy != null && Vector3.Distance(transform.position, enemy.transform.position) > 5)
                {

                    GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().close_count = 2;
                    notclosetext.text = "The enemy is too far to you!";
                }
                else
                {
                    player.count = 0;
                    player.nom_fighting_status = false;
                    player.fighting_status = true;
                    skillsound.Play();
                    pm.allowwalk = false;
                    player.ManaPoint -= manause;
                    ps.ss = skillState.skill1;
                    animator.SetBool("run", false);
                    animator.SetBool("walk", false);
                    animator.SetBool("skill2", true);
                    animator.SetBool("skill3", false);
                    animator.SetBool("skill4", false);
                    animator.SetBool("skill1", false); cd_count = cd; StartCoroutine(animatorcancel()); StartCoroutine(allowwalk());
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
    IEnumerator damage()
    {
        yield return new WaitForSeconds(1.0f);
        skillok = true;
    }

    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("skill2", false);

    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(2.133f);
        ps.ss = skillState.no;
        pm.allowwalk = true;
        skillsound.Stop();

    }
    public void cold_cown()
    {
        if (cd_count > 0)
        {
            cd_count--;
        }
    }
}
