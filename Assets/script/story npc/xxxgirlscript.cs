using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xxxgirlscript : MonoBehaviour
{
    public Animator animator;
    public zackscript zack;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(settalk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setidlemethod()
    {
        StartCoroutine(settalk());
    }
    IEnumerator setidle()
    {
        yield return new WaitForSeconds(3.7f);
        animator.SetBool("talk", false);
        zack.setidlemethod();
    }

    IEnumerator settalk()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("talk", true);
        StartCoroutine(setidle());

    }
}
