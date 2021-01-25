using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene3 : MonoBehaviour
{
    public AudioSource deadsound;
    Animator animator;
    public GameObject model, DeadCanvas, Canvas;
    // Start is called before the first frame update
    void Start()
    {
        model = GameObject.FindGameObjectWithTag("Player");
        animator = model.GetComponent<Animator>();
        deadsound = model.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        model = GameObject.FindGameObjectWithTag("Player");
    }
    public void switchscenename(string scene)
    {
      
        deadsound.Stop();
        animator.SetBool("dead", false);
        animator.SetBool("skill1", false);
        animator.SetBool("skill2", false);
        animator.SetBool("skill3", false);
        animator.SetBool("skill4", false);
        animator.SetBool("walk", false);
        animator.SetBool("run", false);
        animator.SetBool("attack", false);
        player.HealthPoint = player.main_Max_HealthPoint;
        player.ManaPoint = player.main_Max_ManaPoint;
        player.exp *= 1 / 2;
        DeadCanvas.SetActive(false); 
        player.dead = false;
        player.isdead = false;
        Application.LoadLevel(scene);
    }

}
