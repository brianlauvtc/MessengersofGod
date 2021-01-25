using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowInventoryDetail : MonoBehaviour
{
    public InventoryItem item;
    public Image item_image;
    public Text Item_Name, Selling_Price, HP_provide, Defense_Provide, Damage_provide, RebornText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item == null)
        {
            item_image.sprite = null;
            Item_Name.text = "";
            Selling_Price.text = "";
            HP_provide.text = "";
            Defense_Provide.text = "";
            Damage_provide.text = "";
            RebornText.text = "";
        }
        if (item != null)
        {
            item_image.sprite = item.sprite;
            Item_Name.text = item.Itemname;
            if (item.Type == type.crystal || item.Type == type.missionobject)
            {
                
                
                Selling_Price.text = "Cannot sell this item.";
                HP_provide.text = "";
                Defense_Provide.text = "";
                Damage_provide.text = "";
                RebornText.text = "";
            }
            if (item.Type == type.prop)
            {
                Selling_Price.text = "Selling Price : " + item.sell_price.ToString();
                HP_provide.text = "";
                Defense_Provide.text = "";
                Damage_provide.text = "";
                if (item.Restoretype == restoretype.hp)
                {
                    RebornText.text = "HP reborn : " + item.restore.ToString();
                }
                else if (item.Restoretype == restoretype.mp)
                {
                    RebornText.text = "MP reborn : " + item.restore.ToString();

                }
            }
            if (item.Type == type.equipment)
            {
                Selling_Price.text = "Selling Price : " + item.sell_price.ToString();
                HP_provide.text = "Bouns HP amount : " + item.hp_bonus.ToString();
                Defense_Provide.text = "Bouns Defense : " + item.Defense_bonus.ToString();
                Damage_provide.text = "";
                RebornText.text = "";
            }
            if (item.Type == type.weapon)
            {
                Selling_Price.text = "Selling Price : " + item.sell_price.ToString();
                HP_provide.text = "";
                Defense_Provide.text = "";
                RebornText.text = "";
                Damage_provide.text = "Bonus Damage : " + item.damage_bonus.ToString();
            }
        }
    }
}
