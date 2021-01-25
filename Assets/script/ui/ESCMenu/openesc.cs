using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openesc : MonoBehaviour
{
    public GameObject esc;
    public GameObject dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open() { if (player.HealthPoint > 0) { esc.SetActive(true); dead.SetActive(false); } else { dead.SetActive(false); esc.SetActive(true); } }

}
