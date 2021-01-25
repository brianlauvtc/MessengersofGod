using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setparent : MonoBehaviour
{
    GameObject spawnpoint;
    GameObject player;
   public GameObject maincamera;
    cameracontrol cameracontrolobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnpoint = GameObject.FindGameObjectWithTag("cameralookat");
        player = GameObject.FindGameObjectWithTag("Player");
        spawnpoint.transform.SetParent(player.transform);
        spawnpoint.transform.localPosition = new Vector3(0, 0.542f, 0);
    }
}
