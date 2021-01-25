using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openmaterial : MonoBehaviour
{
    public GameObject open;
    public GameObject close;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openOpen()
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}
