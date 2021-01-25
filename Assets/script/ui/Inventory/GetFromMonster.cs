using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFromMonster : MonoBehaviour
{
    public static InventoryItem[] items = new InventoryItem[21];
    public static int[] itemCount = new int[21];
    public static int axb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void AddItem2(InventoryItem itemToAdd)
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
                    
                    break;
                }
                else if (items[i] == null)
                {
                    items[i] = itemToAdd;
                    itemCount[i] += 1;                
                                       
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
                 
                    break;
                }
                else if (items[i] == null)
                {
                    items[i] = itemToAdd;
                    itemCount[i] += 1;
                  
                    return;
                }
            }

        }



    }
}
