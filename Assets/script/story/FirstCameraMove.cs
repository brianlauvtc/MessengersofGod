using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCameraMove : MonoBehaviour
{
    public GameObject target;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float step = time * Time.deltaTime;
        if (Vector3.Distance(this.transform.position, target.transform.position) < 0.1f)
        {

        }
        else { this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, step); }
  
    }
}
