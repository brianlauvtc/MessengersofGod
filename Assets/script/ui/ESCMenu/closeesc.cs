using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeesc : MonoBehaviour
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
    public void closeEsc() { esc.SetActive(false); if (player.HealthPoint <= 0) { dead.SetActive(true); } }
}
