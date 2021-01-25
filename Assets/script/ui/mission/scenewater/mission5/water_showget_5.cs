using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_showget_5 : MonoBehaviour
{
    public GameObject get;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenewater_m5_accept == false && player.scenewater_m4 == true)
        {
            get.SetActive(true);
        }
        else { get.SetActive(false); }
    }
}
