using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class posit : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<RectTransform>().position = new Vector3(0, 0, 0);
    }
}
