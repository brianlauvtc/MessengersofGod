using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_getmisison_1 : MonoBehaviour
{
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( player.sceneearth_m1 == false && player.sceneearth_m1_accept == true)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
