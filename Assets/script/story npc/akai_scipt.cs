using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akai_scipt : MonoBehaviour
{
    public Animator animator;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(random());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator random()
    {
        yield return new WaitForSeconds(5f);
        num = UnityEngine.Random.Range(0, 2);
        if (num == 1)
        {
            StartCoroutine(setlaugh());
        }
        else
        {
            StartCoroutine(random());
        }


    }

    IEnumerator setidle()
    {
        yield return new WaitForSeconds(14f);
        animator.SetBool("laugh", false);
        StartCoroutine(random());
    }

    IEnumerator setlaugh()
    {
        yield return new WaitForSeconds(0f);
        animator.SetBool("laugh", true);
        StartCoroutine(setidle());

    }

  
}
