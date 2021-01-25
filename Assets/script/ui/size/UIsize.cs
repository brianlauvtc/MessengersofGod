using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIsize : MonoBehaviour
{
    public int widthPercentage;
    public int heightPercentage;
	public RectTransform self;
	public RectTransform mainUI;
	// Start is called before the first frame update
	void Awake(){

	}

	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
        self.sizeDelta = new Vector2(mainUI.rect.width/100* widthPercentage, mainUI.rect.height/100* heightPercentage);
        //self.GetComponent<RectTransform>().anchoredPosition =
            //new Vector2(0, 0);
    }
}
