using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice_GetMission6 : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.sceneice_m5 == true && player.sceneice_m6 == false)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
