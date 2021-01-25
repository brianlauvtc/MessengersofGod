using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHotKey : MonoBehaviour
{   public InventorySelect IS;
    public Inventory inventory;
    public hotkeylist hkl;
    int num, se;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (IS.selectnum != 22)
        {
            if ( (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) && inventory.items[IS.selectnum].Type == type.prop)
            {
                if (hkl.item[0] == null)
                {
                
                    hkl.addhotkey(0, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]);
                    num = inventory.itemCount[IS.selectnum];
                    se = IS.selectnum;
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                   
                }
                else if (hkl.item[0] != null)
                {
                 
                    for (int i = 0; i < hkl.num[0]; i++)
                    {
                   
                        inventory.AddItem2(hkl.item[0]);
                    }
             
                    hkl.addhotkey(0, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]);
                    num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
               
                }
            }
            if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) && inventory.items[IS.selectnum].Type == type.prop)
            {
                
                if (hkl.item[1] == null)
                {
                    hkl.addhotkey(1, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]);
                    num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum],IS.selectnum); }
                    
                }
                else if (hkl.item[1] != null)
                {
                    for (int i = 0; i < hkl.num[1]; i++)
                    {
                        inventory.AddItem2(hkl.item[1]);
                    }
                    hkl.addhotkey(1, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
      
                }
            }
            if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) && inventory.items[IS.selectnum].Type == type.prop)
            {
              
                if (hkl.item[2] == null)
                {
                    hkl.addhotkey(2, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                   
                }
                else if (hkl.item[2] != null)
                {
                    for (int i = 0; i < hkl.num[2]; i++)
                    {
                        inventory.AddItem2(hkl.item[2]);
                    }
                    hkl.addhotkey(2, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                 
                }
            }
            if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) && inventory.items[IS.selectnum].Type == type.prop)
            {
                if (hkl.item[3] == null)
                {
                    hkl.addhotkey(3, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                    
                }
                else if (hkl.item[3] != null)
                {
                    for (int i = 0; i < hkl.num[3]; i++)
                    {
                        inventory.AddItem2(hkl.item[3]);
                    }
                    hkl.addhotkey(3, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum],IS.selectnum); }
                
                }
            }
            if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) && inventory.items[IS.selectnum].Type == type.prop)
            {

                if (hkl.item[4] == null)
                {
                    hkl.addhotkey(4, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                   
                }
                else if (hkl.item[4] != null)
                {
                    for (int i = 0; i < hkl.num[4]; i++)
                    {
                        inventory.AddItem2(hkl.item[4]);
                    }
                    hkl.addhotkey(4, inventory.items[IS.selectnum], inventory.itemCount[IS.selectnum]); num = inventory.itemCount[IS.selectnum];
                    for (int i = 0; i < num; i++)
                    { inventory.RemoveItem(inventory.items[IS.selectnum], IS.selectnum); }
                   
                }
            }
        }

    }
   
}
