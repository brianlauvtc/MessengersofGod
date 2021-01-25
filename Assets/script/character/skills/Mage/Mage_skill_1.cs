using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mage_skill_1 : MonoBehaviour {
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

    public player_move pm;
    public player_status ps;

    public bool[] target = new bool[29];
    public float[] distancea = new float[29];
    public float[] anglea = new float[29];
    public GameObject[] enemy = new GameObject[29];

    public bool skillok;
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
        enemy = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().enemy;
        skilltext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().skiltext;
        Panel = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().Panel[0];
        Panel.fillAmount = cd_count / cd;
        main_damage = basic_damage + (skill_level - 1) * grow_damage + ((player.main_attack_damage / 10) * attack_damage_bonus);
        if (Input.GetKeyDown(KeyCode.Q) && cd_count > 0 && ps.ss == skillState.no && animator.GetBool("attack") == false)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.W))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().cd_count = 2;
                skilltext.text = skillname + " is not ready for use. ";
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint < manause)
        {
            if (Input.GetKeyDown(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.W))
            {
                GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().manacd_count = 2;
                manatext.text = "You have no enough manapoint to use " + skillname;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) && cd_count <= 0 && ps.ss == skillState.no && animator.GetBool("attack") == false && player.ManaPoint >= manause && player.HealthPoint > 0)
        {
            if (Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.R))
            {
                skillsound.Play();
                pm.allowwalk = false;
                player.ManaPoint -= manause;
                ps.ss = skillState.skill1;
                animator.SetBool("run", false);
                animator.SetBool("walk", false);
                animator.SetBool("skill2", false);
                animator.SetBool("skill3", false);
                animator.SetBool("skill4", false);
                animator.SetBool("skill1", true); cd_count = cd; StartCoroutine(animatorcancel()); StartCoroutine(allowwalk());
                StartCoroutine(damage());





            }

        }

        if (skillok == true)
        { check(); }

    }
    IEnumerator damage()
    {
        yield return new WaitForSeconds(1.2f);
        skillok = true;
    }
    public void check()
    {

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
                if (jiajiao <= 50 * 0.5f)
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

        skillok = false;

    }




    IEnumerator animatorcancel()
    {
        yield return new WaitForSeconds(1.0f);
        animator.SetBool("skill1", false);

    }
    IEnumerator allowwalk()
    {
        yield return new WaitForSeconds(2.42f);
        ps.ss = skillState.no;
        pm.allowwalk = true;
        skillsound.Stop();
        for (int i = 0; i < 29; i++)
        {
            target[i] = false;
        }
    }
}
