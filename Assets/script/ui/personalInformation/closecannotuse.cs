using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closecannotuse : MonoBehaviour
{
    public GameObject cannotuse;
    public ShowInventoryDetail SSID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SSID != null)
            {
                SSID.item = null;
            }
        }
    }
    public void close() {
        cannotuse.SetActive(false);
        if (SSID != null)
        {
            SSID.item = null;
        }
    }
}
