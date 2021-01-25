using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public Image[] itemImages = new Image[21];
    public InventoryItem[] items = new InventoryItem[21];
    public Text[] counts = new Text[21];
    public int axb;
    public int axc;
    public int[] itemCount = new int[21];
    public hotkeylist hkl;
    public InventorySelect IS;
    void Start()
    {
       
     
    }
    void Update()
    {
        for (int gg = 0; gg < 21; gg++)
        { if (itemCount[gg] <= 0)
            { itemCount[gg] = 0;
                items[gg] = null;
                itemImages[gg].sprite = null;
                counts[gg].text = "";
            }
        }
        for (int i = 0; i < 21; i++)
        {
            if (items[i] != null)
            {
                if (itemCount[i] <= 99 && !(itemCount[i] <= 0))
                { counts[i].text = itemCount[i].ToString(); }
                else if(itemCount[i] >99) { counts[i].text = "99+"; }
            }
            else { counts[i].text = "";
                itemCount[i] = 0;
                itemImages[i].name = "ItemImage";
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
            }
         

        }

       // if (Input.GetKeyDown(KeyCode.G))
        { refresh(); }
    }
    public void refresh()
    {
        for (int abc = 0; abc < 21; abc++)
        {
            
            if (items[abc] == null)
            {
                for (int bcd = abc+1; bcd < 21; bcd++)
                {
                    if (items[bcd] != null)
                    {
                        items[abc] = items[bcd];
                        itemCount[abc] = itemCount[bcd];
                        if (itemCount[abc] <= 99)
                        { counts[abc].text = itemCount[abc].ToString(); }
                        else { counts[abc].text = "99+"; }
                        itemImages[abc].sprite = items[bcd].sprite;
                        itemImages[abc].name = items[bcd].Itemname + " = " + itemCount[abc].ToString();
                        itemImages[abc].enabled = true;
                        int nums = itemCount[bcd];
                        for (int c = 0; c < itemCount[bcd]; c++)
                        {
                            RemoveItem(items[bcd], bcd);
                            
                        }
                        itemImages[bcd].sprite = null;
                        itemImages[bcd].enabled = false;
                        itemCount[bcd] = 0;
                        counts[bcd].text = "";                       
                        itemImages[bcd].name = "ItemImage";
                        break;
                    }
                }
                    
            }
        }
        
    }
    public void AddItem2(InventoryItem itemToAdd)
    {
        axb = 0;
       
      
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                { axb++; }
                else if (items[i] != null && items[i] != itemToAdd)
                { axb++; }
                else
                {
                    if (items[i] == itemToAdd)
                    {
                        itemCount[i] += 1;
                        itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                        
                        break;
                    }
                    else if (items[i] == null)
                {
                        items[i] = itemToAdd;
                        itemCount[i] += 1;
                        counts[i].text = itemCount[i].ToString();
                       
                        itemImages[i].sprite = itemToAdd.sprite;
                        itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                        itemImages[i].enabled = true;
                        return;
                    }
                }

            }
            if (axb == 21)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == itemToAdd)
                    {
                        itemCount[i] += 1;
                        itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                        if (itemCount[i] <= 99)
                        { counts[i].text = itemCount[i].ToString(); }
                        else { counts[i].text = "99+"; }
                        break;
                    }
                    else if (items[i] == null)
                    {
                    items[i] = itemToAdd;
                        itemCount[i] += 1;
                        counts[i].text = itemCount[i].ToString();
                        
                        itemImages[i].sprite = itemToAdd.sprite;
                        itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                        itemImages[i].enabled = true;
                        return;
                    }
                }

            }
        


    }

    public void AddItem(InventoryItem itemToAdd)
    {
        axb = 0;
        axc = 0;
        for (int i = 0; i < 5; i++)
        {if (hkl.item[i] == null)
            {
                axc++;
            }
            else if (hkl.item[i] != null && hkl.item[i] != itemToAdd)
            { axc++; }
            else if (hkl.item[i] == itemToAdd)
            {
                hkl.num[i]++;
                return;
            }
                   
        }
        if(axc == 5)
        { 
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            { axb++; }
            else if (items[i] != null && items[i] != itemToAdd)
            { axb++; }
            else
            {
                if (items[i] == itemToAdd)
                {
                    itemCount[i] += 1;
                    itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                    if (itemCount[i] <= 99)
                    { counts[i].text = itemCount[i].ToString(); }
                    else { counts[i].text = "99+"; }
                    break;
                }
                else if (items[i] == null)
                {
                    itemCount[i] += 1;
                    counts[i].text = itemCount[i].ToString();
                    items[i] = itemToAdd;
                    itemImages[i].sprite = itemToAdd.sprite;
                    itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                    itemImages[i].enabled = true;
                    return;
                }
            }

        }
        if (axb == 21)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToAdd)
                {
                    itemCount[i] += 1;
                    itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                    if (itemCount[i] <= 99)
                    { counts[i].text = itemCount[i].ToString(); }
                    else { counts[i].text = "99+"; }
                    break;
                }
                else if (items[i] == null)
                {
                    itemCount[i] += 1;
                    counts[i].text = itemCount[i].ToString();
                    items[i] = itemToAdd;
                    itemImages[i].sprite = itemToAdd.sprite;
                    itemImages[i].name = itemToAdd.Itemname + " = " + itemCount[i].ToString();
                    itemImages[i].enabled = true;
                    return;
                }
            }

        }
    }


    }
    public void RemoveItem(InventoryItem itemToRemove, int num)
    {
       
        for (int i = 0; i < items.Length; i++)
        {if( i == num)
            { 
            if (items[i] == itemToRemove && itemCount[i] > 1)
            {
                    

                    itemCount[i] -= 1;
                itemImages[i].name = itemToRemove.Itemname + " = " + itemCount[i].ToString();
                if (itemCount[i] <= 99)
                { counts[i].text = itemCount[i].ToString(); }
                else { counts[i].text = "99+"; }

            }
            else if (items[i] == itemToRemove && itemCount[i]== 1)
                {

                    IS.selectedimage = null;
                   
                    itemCount[i] -= 1;
                    counts[i].text = ""; 

                    items[i] = null; 
                    itemImages[i].name = "ItemImage"; 
                    itemImages[i].sprite = null; 
                    itemImages[i].enabled = false; 
                    return;
            }
        }
        }

    }
  


  

}