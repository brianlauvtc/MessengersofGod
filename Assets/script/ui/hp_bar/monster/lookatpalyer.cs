using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatpalyer : MonoBehaviour
{
    public Transform cameraPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos =  GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().transform;
       
       this.transform.LookAt(new Vector3(cameraPos.position.x, this.transform.position.y, cameraPos.position.z)); 
       
        
    }
}
