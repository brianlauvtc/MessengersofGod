using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class closerrespawn : MonoBehaviour
{
    private NavMeshAgent agent;
    public AudioSource deadsound;
    Animator animator;
   public GameObject model, DeadCanvas, Canvas, respawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        model = GameObject.FindGameObjectWithTag("Player");
        agent = model.GetComponent<NavMeshAgent>();
        animator = model.GetComponent<Animator>();
        deadsound = model.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        model = GameObject.FindGameObjectWithTag("Player");
        agent = model.GetComponent<NavMeshAgent>();
    }

    public void respawn()
    {
        Canvas.SetActive(true);
        deadsound.Stop();
        animator.SetBool("dead", false);
        player.HealthPoint = player.main_Max_HealthPoint;
        player.ManaPoint = player.main_Max_ManaPoint;
        player.exp *= 1 / 2;          
        model.transform.position = respawnpoint.transform.position;
        agent.SetDestination(transform.position);
        player.dead = false;
        player.isdead = false;
        DeadCanvas.SetActive(false);
    }


}
