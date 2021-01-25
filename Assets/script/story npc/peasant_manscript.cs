using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peasant_manscript : MonoBehaviour
{
    public Animator animator;
    public GameObject character;
    public GameObject[] pos = new GameObject[2];
    public float speed;
    int current;
    int target;
    bool walk;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        StartCoroutine(setwalk());
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (walk == true)
        {
            character.transform.position = Vector3.MoveTowards(character.transform.position, pos[target].transform.position, step);
        }
        if (Vector3.Distance(character.transform.position, pos[target].transform.position) < 1f && walk == true)
        {
            walk = false;
            current = target;
            StartCoroutine(setidle());
        }
    }

    IEnumerator setwalk()
    {
        yield return new WaitForSeconds(5f);
        animator.SetBool("walk", true);
        if(current == 0)
        {
            target = 1;

            character.transform.LookAt(pos[target].transform);
            walk = true;
        } else if (current == 1)
        {
            target = 0;
            character.transform.LookAt(pos[target].transform);
            walk = true;
        }


    }
    IEnumerator setidle()
    {
        yield return new WaitForSeconds(0f);
        animator.SetBool("walk", false);
        StartCoroutine(setwalk());

    }
}
