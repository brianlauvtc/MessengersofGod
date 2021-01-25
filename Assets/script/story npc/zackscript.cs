using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zackscript : MonoBehaviour
{
    public Animator animator;
    public xxxgirlscript girl;
    // Start is called before the first frame update
    void Start()
    {

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
        yield return new WaitForSeconds(3.9f);
        animator.SetBool("talk", false);
        girl.setidlemethod();
    }

    IEnumerator settalk()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("talk", true);
        StartCoroutine(setidle());

    }
}
