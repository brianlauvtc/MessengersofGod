using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exe_red_script : MonoBehaviour
{
    public untitledmainscript Uuntitledmainscript;
    public Animator animator;
    bool talk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Uuntitledmainscript.idle_b_ok == true && talk == false)
        {
            StartCoroutine(talk_animation());
        }
        if (Uuntitledmainscript.idle_b_ok == false && talk == true)
        {
            StartCoroutine(talk_to_false());
        }
    }

    IEnumerator talk_animation()
    {
        yield return new WaitForSeconds(0f);
        talk = true;
        animator.SetBool("talk", true);
        StartCoroutine(idle());
    }

    IEnumerator idle()
    {
        yield return new WaitForSeconds(3.7f);
        animator.SetBool("talk", false);
     
    }
    IEnumerator talk_to_false()
    {
        yield return new WaitForSeconds(0f);
        talk = false;

    }
}
