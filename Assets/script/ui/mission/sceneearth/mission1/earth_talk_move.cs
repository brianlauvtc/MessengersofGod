using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_talk_move : MonoBehaviour
{
    public earth_talk et;
    public GameObject back;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (et.i == 0)
        {
            back.SetActive(false);
        }
        else { back.SetActive(true); }

        if (et.i == et.introduction.Length-1)
        {
            next.SetActive(false);
        }
        else { next.SetActive(true); }
    }
    public void add()
    {   if(et.i <et.introduction.Length-1)
        et.i++;
    }
    public void reduce()
    {
        if (et.i >0)
            et.i--;
    }
}
