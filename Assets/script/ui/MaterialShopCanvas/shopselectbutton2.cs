using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopselectbutton2 : MonoBehaviour
{
    public InventoryItem saleitem;
    public materialshopselect ass;
    public InputField num;
    public buyamount2 bm2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectitem(int i)
    {
        num.text = "1";
        bm2.num = 0;
        ass.selectbuyitem(saleitem, i);
    }

}
