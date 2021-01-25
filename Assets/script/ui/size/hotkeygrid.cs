using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hotkeygrid : MonoBehaviour
{
    public RectTransform mainUI;
    public int widthPercentage;
    public GridLayoutGroup glg;
    public RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        glg.cellSize.Set(glg.cellSize.x, mainUI.rect.width / 100 * widthPercentage);
    }
}
