using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untitledmainscript : MonoBehaviour
{
    public Animator animator;
    public GameObject character;
    public GameObject[] pos = new GameObject[3];
    public GameObject mid;
    public float speed;
    int random_number;
    int current_pos;
    int next_pos;
    bool random_is_ok;
    bool walking_to_mid;
    bool walking_to_target;
    public bool idle_b_ok; 


    // Start is called before the first frame update
    void Start()
    {
        current_pos = 2;
        StartCoroutine(random_start());
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (walking_to_mid == true && random_is_ok == true)
        {
            character.transform.position = Vector3.MoveTowards(character.transform.position, mid.transform.position, step);
        }
        if (Vector3.Distance(character.transform.position, mid.transform.position) < 1f && random_is_ok == true)
        {
            walking_to_mid = false;
            StartCoroutine(idle_mid());
            StartCoroutine(walk_to_target());
        }
        if (walking_to_target == true && random_is_ok == true)
        {
            character.transform.position = Vector3.MoveTowards(character.transform.position, pos[next_pos].transform.position, step);
        }
        if (Vector3.Distance(character.transform.position, pos[next_pos].transform.position) < 1f && random_is_ok == true)
        {
            walking_to_target = false;
            random_is_ok = false;
            current_pos = next_pos;
            if (next_pos == 2)
            {
                StartCoroutine(idle_a());
            }
            else
            {
                StartCoroutine(idle());
            }
        
        }
    }

     IEnumerator random_start()
    {
        yield return new WaitForSeconds(2f);
        do { random_number = UnityEngine.Random.Range(0, 3); }
        while (random_number == current_pos);
        next_pos = random_number;
        random_is_ok = true;
        StartCoroutine(walk_to_mid());
    }
    IEnumerator random()
    {
        yield return new WaitForSeconds(5f);
        idle_b_ok = false;
        do { random_number = UnityEngine.Random.Range(0, 3); }
        while (random_number == current_pos);
        next_pos = random_number;
        random_is_ok = true;
        StartCoroutine(walk_to_mid());
    }
    IEnumerator walk_to_mid()
    {
        yield return new WaitForSeconds(1f);
        character.transform.LookAt(mid.transform);
        animator.SetBool("walk", true);
        animator.SetBool("talk", false);
        walking_to_mid = true;

    }

    IEnumerator walk_to_target()
    {
        yield return new WaitForSeconds(1f);
        character.transform.LookAt(pos[next_pos].transform);
        animator.SetBool("walk", true);
        animator.SetBool("talk", false);
        walking_to_target = true;

    }
    IEnumerator idle_a()
    {
        yield return new WaitForSeconds(0f);
        animator.SetBool("talk", false);
        animator.SetBool("walk", false);
        StartCoroutine(talk());
    }
    IEnumerator talk()
    {
        yield return new WaitForSeconds(3f);
        animator.SetBool("talk", true);
        animator.SetBool("walk", false);
        StartCoroutine(idle_b());

    
    }

    IEnumerator idle_b()
    {
        yield return new WaitForSeconds(4f);
        idle_b_ok = true;
        animator.SetBool("talk", false);
        animator.SetBool("walk", false);
        StartCoroutine(random());
    }

    IEnumerator idle()
    {
        yield return new WaitForSeconds(0f);
        animator.SetBool("talk", false);
        animator.SetBool("walk", false);
        StartCoroutine(random());
    }

    IEnumerator idle_mid()
    {
        yield return new WaitForSeconds(0f);
        animator.SetBool("talk", false);
        animator.SetBool("walk", false);
        
    }

}