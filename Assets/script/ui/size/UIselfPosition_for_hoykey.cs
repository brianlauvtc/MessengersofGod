using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIselfPosition_for_hoykey : MonoBehaviour
{
    public float Xpos;
    public float Ypos;
    public float addYpos;
    public int count;
    public RectTransform self;
    public RectTransform picture;
    public RectTransform mainUI;
    // Start is called before the first frame update
    void Start()
    {
        addYpos = count * - picture.sizeDelta.y;

        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100, mainUI.rect.height * Ypos / 100 + addYpos);
    }

    // Update is called once per frame
    void Update()
    {
        addYpos = count * -picture.sizeDelta.y;
        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100, mainUI.rect.height * Ypos / 100 + addYpos);
    }
}
