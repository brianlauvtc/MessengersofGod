using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnsave : MonoBehaviour
{
    public GameObject obj;
    public GameObject spawm_obj;
    // Start is called before the first frame update
    void Start()
    {
        if (startsave.load == false)
        {
            Instantiate(spawm_obj, obj.transform.position, obj.transform.rotation);
            startsave.load = true; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
