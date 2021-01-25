using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_GetMission4 : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.scenewater_m3 == true && player.scenewater_m4 == false)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
