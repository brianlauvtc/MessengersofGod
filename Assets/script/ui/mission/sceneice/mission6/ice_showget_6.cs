using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_showget_6 : MonoBehaviour
{
    public GameObject get;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.sceneice_m6_accept == false && player.sceneice_m5 == true)
        {
            get.SetActive(true);
        }
        else { get.SetActive(false); }
    }
}
