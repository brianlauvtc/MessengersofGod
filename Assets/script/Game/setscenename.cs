using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setscenename : MonoBehaviour
{
    public string namel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.scene_name = namel;
    }
}
