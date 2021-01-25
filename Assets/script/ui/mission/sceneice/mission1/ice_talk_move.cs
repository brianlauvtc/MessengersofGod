using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_talk_move : MonoBehaviour
{
    public ice_talk it;
    public GameObject back;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (it.i == 0)
        {
            back.SetActive(false);
        }
        else { back.SetActive(true); }

        if (it.i == it.introduction.Length - 1)
        {
            next.SetActive(false);
        }
        else { next.SetActive(true); }
    }
    public void add()
    {   if(it.i <it.introduction.Length-1)
        it.i++;
    }
    public void reduce()
    {
        if (it.i >0)
            it.i--;
    }
}
