using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monster_spawner : MonoBehaviour
{
    public monster_num mm;
    public enemycount ec;
    public AudioSource attacksound;
    public AudioSource idlesound;
    public bool idlesoundplay;
    public AudioSource deadsound;
    public AudioSource movesound;
    public bool attackplayer;
    public bossmonsterdrop bmd;
    public monsterdrop md;
    public GameObject spawn_point;
    public GameObject monster;
    public GameObject[] movepoint;
    public int now;
    public float disappeartime;
    public float attacktime;
    public float attackanimtime;
    public float respawntime;
    public Text killtext;
    public bool ok;
    public float attackdistance;
    public GameObject playerobj;
    public bool done;
    public bool moving;
    public int randomNumber; 
    Animator animator;
    Monster_Character_Attribute mca;
    public bool dead;
    public GameObject hp_bar;
    public string name2;
    public bool playerdead;
    public bool getdamage;
    // Start is called before the first frame update
    void Start()
    {
        idlesoundplay = false;
           attackplayer = false;
       md = this.gameObject.GetComponent<monsterdrop>();
       bmd = this.gameObject.GetComponent<bossmonsterdrop>();
        getdamage = false;
        done = false;
        moving = false;
        playerdead = false; 
        dead = false;
        mca = monster.GetComponent<Monster_Character_Attribute>();
        animator = monster.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        mm = spawn_point.gameObject.GetComponent<monster_num>();
        ec = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>();
        hp_bar = ec.hp_bar[mm.getnum()];
        killtext = ec.killtext;
       

        playerobj = GameObject.FindGameObjectWithTag("Player");
        float step = 1f * Time.deltaTime;
        if (player.HealthPoint <= 0)
        {
            attackplayer = false;
            getdamage = false;
        }
        if (player.HealthPoint <= 0 && playerdead == false)
        {
            playerdead = true;
            mca.HealthPoint = mca.Max_HealthPoint;
            animator.SetBool("dead", false);
            animator.SetBool("attack", false);
            done = false;
            dead = false;
            moving = false;
            getdamage = false;
            ok = false;
            attackplayer = false;
       

        }
        if (player.HealthPoint > 0)
        {
            playerdead = false;
        }

            if (getdamage == true)
        {
            player.nom_fighting_status = false;
            player.fighting_status = true;
            player.count = 0;
            if (dead == false)
            {
                monster.transform.LookAt(playerobj.transform);
                if (Vector3.Distance(monster.transform.position, playerobj.transform.position) < attackdistance && moving == true)
                {
                    animator.SetBool("walk", false);
                    moving = false;




                }
                if (Vector3.Distance(monster.transform.position, playerobj.transform.position) < attackdistance && moving == false)
                {
                    if (attackplayer == false)
                {
                    if (attackplayer == false && dead == false && mca.HealthPoint > 0 )
                    {
                       
                        animator.SetBool("attack", true);
                        animator.SetBool("walk", false);

                            if (animator.GetBool("walk") == false && animator.GetBool("attack") == true && moving == false)
                            {
                                movesound.Stop();
                                attackplayer = true;
                                StartCoroutine(cut());
                                attacksound.Play();
                                playerobj.GetComponent<Player_Character_Attribute>().get_damage(mca.attack_damage);
                                StartCoroutine(attack());
                            }
                    }
                }
            }

                if (Vector3.Distance(monster.transform.position, playerobj.transform.position) > attackdistance && moving == false)
                {
                    animator.SetBool("attack", false);
                  
                    animator.SetBool("walk", true);
                    moving = true;
                   
                }
                if (moving == true)
                {
                    monster.transform.position = Vector3.MoveTowards(monster.transform.position, playerobj.transform.position, step);
                }
            }


        }

        if (getdamage == false && mca.HealthPoint > 0)
        {
            if (moving == false && ok == false)
        {
                ok = true;
               
                StartCoroutine(random());
            }
         
        }
        if (getdamage == false && moving == true && dead == false && done == true)
        {
        
            if (Vector3.Distance(monster.transform.position, movepoint[randomNumber].transform.position) < 0.1f)
            {
                animator.SetBool("walk", false);
                movesound.Stop();
                ok = false;
                moving = false;
                done = false;
            }
            if (moving == true)
            {
                monster.transform.LookAt(movepoint[randomNumber].transform);
                monster.transform.position = Vector3.MoveTowards(monster.transform.position, movepoint[randomNumber].transform.position, step);
            }

        }

      
        if (mca.HealthPoint <= 0 && dead == false)
        {
            playerobj.GetComponent<target_enemy>().target = null ;
             getdamage = false;
            deadsound.Play();
            killtext.text = "You Kill "  + name2;
            animator.SetBool("walk", false);
            animator.SetBool("attack", false);
            hp_bar.SetActive(false);
            StartCoroutine(killtextdisappear());
            animator.SetBool("dead", true);
            if (md != null)
            { md.drop(monster.name); }
            if (bmd != null)
            { bmd.drop(monster.name); }
            StartCoroutine(disappear());
            player.exp += mca.deadexp;
            player.money += mca.deadmoney;
            dead = true;
            
            
           
        }

        if (dead == false &&
          moving == false &&
          getdamage == false &&
          attackplayer == false)
        {if (idlesoundplay == false)
            { idlesound.Play(); idlesoundplay = true; }
        }
        else { if (idlesoundplay == true) { idlesound.Stop(); idlesoundplay = false; } }

    }

 

    IEnumerator killtextdisappear()
    {
        yield return new WaitForSeconds(2f);
        killtext.text = "";
    }

    IEnumerator cut()
    {
        yield return new WaitForSeconds(attackanimtime);
        attacksound.Stop();
        animator.SetBool("attack", false);

    }
    IEnumerator attack()
    {
        yield return new WaitForSeconds(attacktime);
        attackplayer = false;
        

    }
    IEnumerator disappear()
    {
        yield return new WaitForSeconds(disappeartime);
        monster.SetActive(false);
        animator.SetBool("dead", false);
        deadsound.Stop();
        StartCoroutine(respawn());
    }
    IEnumerator respawn()
    {
        yield return new WaitForSeconds(respawntime);

            monster.transform.position = spawn_point.transform.position;
            mca.HealthPoint = mca.Max_HealthPoint;
            animator.SetBool("dead", false);
            animator.SetBool("attack", false);
            done = false;
            dead = false;
            moving = false;
            idlesoundplay = false;
            getdamage = false;
            playerdead = false;
            ok = false;
            attackplayer = false;
            monster.SetActive(true);
        
    }


    IEnumerator random() {
        yield return new WaitForSeconds(4f);
       
        do { randomNumber = UnityEngine.Random.Range(0, 6); }
        while (randomNumber == now || Vector3.Distance(monster.transform.position, movepoint[randomNumber].transform.position) < 1f);

        moving = true;
        now = randomNumber;
              done = true;
        movesound.Play();
        animator.SetBool("walk", true);
          
        
        
    }


}
