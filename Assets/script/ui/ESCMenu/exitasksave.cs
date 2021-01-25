using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitasksave : MonoBehaviour
{
    public GameObject esc, ask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void open() { esc.SetActive(false); ask.SetActive(true); }

}
