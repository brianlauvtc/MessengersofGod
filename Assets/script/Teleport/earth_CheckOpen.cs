using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_CheckOpen : MonoBehaviour
{
    public GameObject ice;
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
    }
}
