using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savefile : MonoBehaviour
{
    public GameObject esc, save;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveFile() { save.SetActive(true);esc.SetActive(false); }
    public void canmelsaveFile() { save.SetActive(false); esc.SetActive(true); }
}
