using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closetpcanvas : MonoBehaviour
{
    public GameObject tpcanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    public void close()
    {
        tpcanvas.SetActive(false);
    }
}

