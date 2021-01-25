using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextSize : MonoBehaviour
{
    public float sizePercentage;
    public RectTransform mainUI;
    public Text self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (mainUI != null)
        { self.fontSize = (int)(mainUI.rect.width / 100 * sizePercentage); }
    }
}
