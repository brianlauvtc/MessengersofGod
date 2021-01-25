using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hotkeylist : MonoBehaviour
{
    public Image[] image = new Image[5];
    public InventoryItem[] item = new InventoryItem[5];
    public int[] num = new int[5];
    public Text[] count= new Text[5];
    public Inventory inventory;
    public GameObject inventorycanvas;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (inventorycanvas.activeInHierarchy == true)
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)))
            {
              
                if (item[0] != null)
                {
                    for (int i = 0; i < num[0]; i++)
                    { inventory.AddItem2(item[0]); }
                }
                item[0] = null;
                num[0] = 0;
            }
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)))
            {
               
                if (item[1] != null)
                {
                    for (int i = 0; i < num[1]; i++)
                    { inventory.AddItem2(item[1]); }
                }
                item[1] = null; num[1] = 0;
            }
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)))
            {
              
                if (item[2] != null)
                {
                    for (int i = 0; i < num[2]; i++)
                    { inventory.AddItem2(item[2]); }
                }
                item[2] = null; num[2] = 0;
            }
            if ( (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)))
            {
                if (item[3] != null)
                {
                    for (int i = 0; i < num[3]; i++)
                    { inventory.AddItem2(item[3]); }
                }
                item[3] = null; num[3] = 0;
            }
            if ( (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)))
            {
              
                if (item[4] != null)
                {
                    for (int i = 0; i < num[4]; i++)
                    { inventory.AddItem2(item[4]); }
                }
                item[4] = null; num[4] = 0;
            }
        }

        for (int i = 0; i < 5; i++)
        {   


            if (item[i] != null)
            {
                image[i].GetComponent<Image>().sprite = item[i].sprite;
                if (num[i] <= 99)
                { count[i].text = num[i].ToString(); }
                else { count[i].text = "99+"; }
                image[i].GetComponent<Image>().enabled = true;

            }
            else { image[i].GetComponent<Image>().sprite = null;
                count[i].text = "";
                image[i].GetComponent<Image>().enabled = false;
            }
        }
    }

    public void addhotkey(int hotkey, InventoryItem _item, int itemcount)
    {
        item[hotkey] = _item;
        num[hotkey] = itemcount;
    }
  
}
