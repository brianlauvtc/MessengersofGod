using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bossmonsterdrop : MonoBehaviour
{
    public Inventory inventorygrids;
    public InventoryItem[] potionlist = new InventoryItem[2];
    public InventoryItem[] equipmentlist = new InventoryItem[9];
    public Text potiontext;
    public string name2;
   
    int x;
    public Text equipmenttext;
    public int randomDroppotion;
    public int randomDropequipment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inventory_canvas = GameObject.FindGameObjectWithTag("inventory");
    }
    public void drop(string name)
    {
       

        randomDroppotion = UnityEngine.Random.Range(1, 11);
        if (randomDroppotion >= 3 && randomDroppotion <= 6)
        {
          
            x= UnityEngine.Random.Range(3, 5);
         
                for (int i = 0; i < x; i++)
                { //if (Inventory_canvas.activeInHierarchy == true)
                { inventorygrids.AddItem(potionlist[0]); }// else { GetFromMonster.AddItem2(potionlist[0]); }
            }
        
            potiontext.text = "You got " + x + " " + potionlist[0].Itemname + " by " + name2;
            StartCoroutine(potiontextdisappear());
        }
        if (randomDroppotion >= 7 && randomDroppotion <= 10)
        {
            x = UnityEngine.Random.Range(3, 5);
           
                for (int i = 0; i < x; i++)
                { //if (Inventory_canvas.activeInHierarchy == true) 
                    { inventorygrids.AddItem(potionlist[1]); } //else { GetFromMonster.AddItem2(potionlist[1]); }
            }
          
            potiontext.text = "You got " + x + " " + potionlist[1].Itemname + " by " + name2;
            inventorygrids.AddItem(potionlist[1]); StartCoroutine(potiontextdisappear());
        }


        randomDropequipment = UnityEngine.Random.Range(1, 101);
        if (randomDropequipment >= 11 && randomDropequipment <= 15)
        {
            equipmenttext.text = "You got a " + equipmentlist[0].Itemname + " by " + name2;
                    // if (Inventory_canvas.activeInHierarchy == true) 
                    { inventorygrids.AddItem(equipmentlist[0]); } //else { GetFromMonster.AddItem2(equipmentlist[0]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 31 && randomDropequipment <= 35)
        {
            equipmenttext.text = "You got a " + equipmentlist[1].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true)
                { inventorygrids.AddItem(equipmentlist[1]); } //else { GetFromMonster.AddItem2(equipmentlist[1]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 71 && randomDropequipment <= 75)
        {
            equipmenttext.text = "You got a " + equipmentlist[2].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true)
                { inventorygrids.AddItem(equipmentlist[2]); } //else { GetFromMonster.AddItem2(equipmentlist[2]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 76 && randomDropequipment <= 80)
        {
            equipmenttext.text = "You got a " + equipmentlist[3].Itemname + " by " + name2;
                //  if (Inventory_canvas.activeInHierarchy == true)
                { inventorygrids.AddItem(equipmentlist[3]); }// else { GetFromMonster.AddItem2(equipmentlist[3]); }
            StartCoroutine(equipmenttextdisappear());
        }

        if (randomDropequipment >= 41 && randomDropequipment <= 45)
        {
            equipmenttext.text = "You got a " + equipmentlist[4].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true) 
                { inventorygrids.AddItem(equipmentlist[4]); }// else { GetFromMonster.AddItem2(equipmentlist[4]); }
            StartCoroutine(equipmenttextdisappear());
        }

        if (randomDropequipment >= 1 && randomDropequipment <= 5)
        {
            equipmenttext.text = "You got a " + equipmentlist[5].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true) 
                { inventorygrids.AddItem(equipmentlist[5]); }// else { GetFromMonster.AddItem2(equipmentlist[5]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 86 && randomDropequipment <= 90)
        {
            equipmenttext.text = "You got a " + equipmentlist[6].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true)
                { inventorygrids.AddItem(equipmentlist[6]); } //else { GetFromMonster.AddItem2(equipmentlist[6]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 61 && randomDropequipment <= 65)
        {
            equipmenttext.text = "You got a " + equipmentlist[7].Itemname + " by " + name2;
                // if (Inventory_canvas.activeInHierarchy == true) 
                { inventorygrids.AddItem(equipmentlist[7]); } //else { GetFromMonster.AddItem2(equipmentlist[7]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 20 && randomDropequipment <= 25)
        {
            equipmenttext.text = "You got a " + equipmentlist[8].Itemname + " by " + name2;
                //if (Inventory_canvas.activeInHierarchy == true) 
                { inventorygrids.AddItem(equipmentlist[8]); }// else { GetFromMonster.AddItem2(equipmentlist[8]); }
            StartCoroutine(equipmenttextdisappear());
        }
    }
    IEnumerator potiontextdisappear()
    {
        yield return new WaitForSeconds(2f);
        potiontext.text = "";
    }
    IEnumerator equipmenttextdisappear()
    {
        yield return new WaitForSeconds(2f);
        equipmenttext.text = "";
    }

}
