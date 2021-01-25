using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIselfPosition_for_hoykey_num : MonoBehaviour
{
    public RectTransform self;
    public RectTransform picture;

    // Start is called before the first frame update
    void Start()
    {
   

        self.anchoredPosition =
            new Vector2( picture.sizeDelta.x/2,  -picture.sizeDelta.y/2 + self.sizeDelta.y/2);
    }

    // Update is called once per frame
    void Update()
    {
    
        self.anchoredPosition =
               new Vector2(picture.sizeDelta.x / 2, -picture.sizeDelta.y / 2 + self.sizeDelta.y / 2);
    }
}
