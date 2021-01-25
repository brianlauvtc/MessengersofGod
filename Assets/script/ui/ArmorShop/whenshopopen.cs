using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenshopopen : MonoBehaviour
{
    public GameObject sellbutton;
    public GameObject ArmorShop;
    public GameObject materialShop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ArmorShop.activeInHierarchy == true || materialShop.activeInHierarchy == true)
        {
            sellbutton.SetActive(true);
        }
        else { sellbutton.SetActive(false); }
    }
}
