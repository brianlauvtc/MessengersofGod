using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class player_move : MonoBehaviour
{
    
    public bool allowwalk;
    public AudioSource attacksound;
    public AudioSource movesound;
    public GameObject inventory, information;
    public GameObject ESCcanvas;
    private NavMeshAgent agent;
    private Vector3 target;
    public float attackdistance;
    Animator animator;
    GameObject model;
    public Ray ray;
    public bool moveing;
    public GameObject SkillCanvas;
    GameObject look_at_enemy;
    Camera main_camera;
     GameObject look_at_point;
    target_enemy te;
    bool attackenemy;
    public player_status ps;
    // Start is called before the first frame update
    void Start()
    {
        allowwalk = true;
           attackenemy = false;
        agent = GetComponent<NavMeshAgent>();
        target = transform.position;
        ESCcanvas = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().ESCMenuCanvas;
      
        SkillCanvas = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().SkillCanvas;
     

        inventory = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().InventoryCanvas;
    
      
        information = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().CharacterInformationCanvas;
       
        model = GameObject.FindGameObjectWithTag("Player");
        ps = model.GetComponent<player_status>();
        moveing = false;
        animator = model.GetComponent<Animator>();
        main_camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        look_at_point = GameObject.FindGameObjectWithTag("lookatpoint");
        te = model.GetComponent<target_enemy>();


    }
    // Update is called once per frame
    void Update()
    {
        //print("repeat = " + player.main_attack_damage);



        if (ESCcanvas.activeInHierarchy == false && player.dead == false )
        {
            ray = main_camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            float step = 13.2f * Time.deltaTime;
            if (Input.GetMouseButton(1)   && Physics.Raycast(ray, out hit)
                && hit.transform.gameObject.tag == "floor" && attackenemy == false && animator.GetBool("run") == false && animator.GetBool("skill1") == false && animator.GetBool("skill2") == false && animator.GetBool("skill3") == false && animator.GetBool("skill4") == false && allowwalk == true)
            {

                moveing = true;
                animator.SetBool("walk", true);
                //model.transform.position += new Vector3(0.1f, 0, 0);
                animator.SetBool("run", false);
                target = hit.point;
                movesound.Play();
                look_at_point.transform.position = hit.point;
                //this.transform.LookAt(look_at_point.transform);
            }

            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "enemy" && te.target != null  && player.HealthPoint > 0 && hit.transform.gameObject.name == "Crystal")
            {
                if (Vector3.Distance(model.transform.position, te.target.transform.position) < attackdistance && ps.ss == skillState.no && animator.GetBool("attack") == false && te.target.GetComponent<crystal_Character_Attribute>().HealthPoint > 0)
                {
                    if (attackenemy == false)
                    {
                        moveing = false;
                        this.transform.LookAt(te.target.transform);
                        player.count = 0;
                        attackenemy = true;
                        animator.SetBool("run", false);
                        animator.SetBool("walk", false);
                        animator.SetBool("attack", true);

                       // agent.SetDestination(transform.position);
                        StartCoroutine(cut());
                        ps.ss = skillState.attack;
                        attacksound.Play();
                       
                        te.target.GetComponent<crystal_Character_Attribute>().get_damage(player.main_attack_damage);

                        StartCoroutine(attack());
                    }
                }

            }


            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "enemy" && te.target!=null &&player.HealthPoint>0 && hit.transform.gameObject.name != "Crystal")
            {
                if (Vector3.Distance(model.transform.position, te.target.transform.position) < attackdistance && ps.ss == skillState.no &&  animator.GetBool("attack") == false && te.target.GetComponent<Monster_Character_Attribute>().HealthPoint > 0)
                {
                    if (attackenemy == false)
                    {
                        moveing = false;
                        this.transform.LookAt(te.target.transform);
                        player.count = 0;
                        attackenemy = true;
                        animator.SetBool("run", false);
                        animator.SetBool("walk", false);
                        animator.SetBool("attack", true);
                   
                        agent.SetDestination(transform.position);
                        StartCoroutine(cut());
                        ps.ss = skillState.attack;
                        attacksound.Play();
           
                        te.target.GetComponent<Monster_Character_Attribute>().get_damage(player.main_attack_damage);

                        StartCoroutine(attack());
                    }
                }
                 
            }

            if (Input.GetMouseButton(1) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "enemy")
            {
                te.settarget(hit.transform.gameObject);
                


            }


            if (moveing == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift) && moveing == true)
                {
                    //step = 13.2f * Time.deltaTime * 4;
                    agent.speed = (float)1 * 4;
                    animator.SetBool("run", true);
                }
                if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    // step = 13.2f * Time.deltaTime;
                    agent.speed = (float)1;
                    animator.SetBool("run", false);
                }

                if (Vector3.Distance(model.transform.position, look_at_point.transform.position) < 0.1f)
                {
                    moveing = false;
                    movesound.Stop();
                    animator.SetBool("run", false);
                    animator.SetBool("walk", false);

                }
                //transform.position = Vector3.MoveTowards(model.transform.position, look_at_point.transform.position, step);
                if (moveing == true)
                { agent.SetDestination(target);  }
                else
                {
                    // agent.SetDestination(transform.position);
                    animator.SetBool("run", false);

                    animator.SetBool("walk", false);
                }

            }
            else { agent.speed = (float)1; movesound.Stop(); }
            if ((Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.R)) && moveing == true)
            {
                agent.SetDestination(transform.position);
                moveing = false;
                animator.SetBool("run", false);
                animator.SetBool("walk", false);


            }



        }
    }
    IEnumerator cut()
    {
        yield return new WaitForSeconds(1f);
        ps.ss = skillState.no;
        attacksound.Stop();
        animator.SetBool("attack", false);

    }


    IEnumerator attack()
    {
        yield return new WaitForSeconds(2f);
      
        attackenemy = false;


    }

}

