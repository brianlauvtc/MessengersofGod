using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_GetMission5 : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenewater_m4 == true && player.scenewater_m5 == false)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
