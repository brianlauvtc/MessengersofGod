using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIselfPosition_for_skill : MonoBehaviour
{
    public float Xpos;
    public float Ypos;
    public float addXpos;
    public int count;
    public RectTransform self;
    public RectTransform picture;
    public RectTransform mainUI;
    // Start is called before the first frame update
    void Start()
    {
        addXpos = count *  picture.sizeDelta.x;

        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100 + addXpos, mainUI.rect.height * Ypos / 100 );
    }

    // Update is called once per frame
    void Update()
    {
        addXpos = count * picture.sizeDelta.x;
        self.anchoredPosition =
            new Vector2(mainUI.rect.width * Xpos / 100 + addXpos, mainUI.rect.height * Ypos / 100 );
    }
}
