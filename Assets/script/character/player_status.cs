using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_status : MonoBehaviour
{
    public skillState ss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
public enum skillState
{
    no, skill1, skill2, skill3, skill4, attack
}