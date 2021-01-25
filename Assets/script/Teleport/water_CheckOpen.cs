using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_CheckOpen : MonoBehaviour
{
    public GameObject ice;
    public GameObject earth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     

        if (player.sceneearth_m1 == true && player.sceneearth_m2 == true && player.sceneearth_m3 == true && player.sceneearth_m4 == true && player.sceneearth_m5 == true && player.sceneearth_m6 == true)
        {
            ice.SetActive(true);
        }
        else { ice.SetActive(false); }


        if (player.scenewater_m1 == true && player.scenewater_m2 == true && player.scenewater_m3 == true && player.scenewater_m4 == true && player.scenewater_m5 == true && player.scenewater_m6 == true)
        {
            earth.SetActive(true);
        }
        else { earth.SetActive(false); }
    }
}
