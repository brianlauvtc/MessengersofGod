using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopselectbutton : MonoBehaviour
{
    public InventoryItem saleitem;
    public armorshopselect ass;
    public ItemList il;
    public Image picture;
    public int itemnum;
    public InputField num;
    public buyamount bm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        saleitem = il.InventoryItemitemToAdd[itemnum];
        picture.sprite = saleitem.sprite;
    }
    public void selectitem(int i)
    {
        num.text = "1";
        bm.num = 0;
        ass.selectbuyitem(saleitem, i);
    }

}
