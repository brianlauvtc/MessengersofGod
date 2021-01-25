using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMan_idle : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setIdle()
    {
        anim.SetBool("idle", true);
    }

}
