using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject ESCcanvas;
    public GameObject target;
    public float maxscrool = 50;
    public float minscrool = 10;
    public float x;
    public float y;
    public float xSpeed=1;          
    public float ySpeed=1;        
    public float distance;        
    public float disSpeed=1;       
    public float minDistance=20;    
    public float maxDistance=50;    

    private Quaternion rotationEuler;
    private Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    { if (ESCcanvas.activeInHierarchy == false)
        { 
        if (Input.GetMouseButton(0)) {
            x += Input.GetAxis("Mouse X") * xSpeed;
            y -= Input.GetAxis("Mouse Y") * ySpeed;
        }
        if (x > 360)
        {
            x -= 360;
        }
        else if (x < 0)
        {
            x += 360;
        }

        if (y <= minscrool)
        {
            y = minscrool;
        }
        if (y >= maxscrool)
        {
            y = maxscrool;
        }

        distance -= Input.GetAxis("Mouse ScrollWheel") * disSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        rotationEuler = Quaternion.Euler(y, x, 0);
        cameraPosition = rotationEuler * new Vector3(0, 0, -distance) + target.transform.position;

        transform.rotation = rotationEuler;
        transform.position = cameraPosition;
    }
    }
}
