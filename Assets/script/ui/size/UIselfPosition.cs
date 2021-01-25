using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIselfPosition : MonoBehaviour
{
    public float Xpos;
    public float Ypos;
    public RectTransform self;
    public RectTransform mainUI;
    // Start is called before the first frame update
    void Start()
    {
        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100, mainUI.rect.height * Ypos / 100);
    }

    // Update is called once per frame
    void Update()
    {
        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100, mainUI.rect.height * Ypos / 100);
    }
}
