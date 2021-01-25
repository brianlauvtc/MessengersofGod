using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.LookAt(target.transform);
    }
}
