using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_talk_move : MonoBehaviour
{
    public fire_talk ft;
    public GameObject back;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ft.i == 0)
        {
            back.SetActive(false);
        }
        else { back.SetActive(true); }

        if (ft.i == ft.introduction.Length - 1)
        {
            next.SetActive(false);
        }
        else { next.SetActive(true); }
    }
    public void add()
    {   if(ft.i <ft.introduction.Length-1)
        ft.i++;
    }
    public void reduce()
    {
        if (ft.i >0)
            ft.i--;
    }
}
