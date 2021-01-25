using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_GetMission3 : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenefire_m2 == true && player.scenefire_m3 == false)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
