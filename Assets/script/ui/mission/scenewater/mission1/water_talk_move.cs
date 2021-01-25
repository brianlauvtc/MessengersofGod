using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_talk_move : MonoBehaviour
{
    public water_talk wt;
    public GameObject back;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wt.i == 0)
        {
            back.SetActive(false);
        }
        else { back.SetActive(true); }

        if (wt.i == wt.introduction.Length - 1)
        {
            next.SetActive(false);
        }
        else { next.SetActive(true); }
    }
    public void add()
    {   if(wt.i <wt.introduction.Length-1)
        wt.i++;
    }
    public void reduce()
    {
        if (wt.i >0)
            wt.i--;
    }
}
