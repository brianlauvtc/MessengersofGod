using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSize : MonoBehaviour
{
    public RectTransform self;
    public RectTransform mainUI;
    public Vector3 max;
    public Vector3 current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mainUI.rect.width >= 1200)
        {  current.x = max.x;
            current.y = max.y;
            current.z = max.z;
            self.localScale = new Vector3(current.x, current.y, current.z);

        }
        else
        {
            current.x = mainUI.rect.width / 1600 * max.x;
            current.y = mainUI.rect.width / 1600 * max.y;
            current.z = max.z;
            self.localScale = new Vector3(current.x, current.y, current.z);
        }
    }
}
