using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dead : MonoBehaviour
{
    public Animator anim;
    public bool always_dead;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void set_always_dead()
    {
        //anim.enabled = false;
    }

    public void setDead()
    {
        anim.SetBool("dead", true);
    }
    

}
