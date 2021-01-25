using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buyamount2 : MonoBehaviour
{   public materialshopselect ass;
    public InputField inputfield;
    public int num;
    
    // Start is called before the first frame update
    void Start()
    {
        num = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if ((player.money / ass.SelectedItem.buyprice) < int.Parse(inputfield.text))
        { inputfield.text = (player.money / ass.SelectedItem.buyprice).ToString(); }
        num = int.Parse(inputfield.text);
    }

    public void plus()
    {
        if (num <   (int)(player.money/ass.SelectedItem.buyprice))
        { int a = int.Parse(inputfield.text);
            a++;
            inputfield.text = a.ToString();
        }
    }

    public void minus()
    {
        if (num > 1)
        {
            int a = int.Parse(inputfield.text);
            a--;
            inputfield.text = a.ToString();
        }
    }
}
