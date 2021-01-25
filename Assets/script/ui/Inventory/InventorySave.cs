using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySave : MonoBehaviour
{
    public Inventory invent;
    public hotkeylist hkl;
    public personalarmor pr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 21; i++)
        {
            InventoryToNextScene.itemCount[i] = invent.itemCount[i];
            InventoryToNextScene.items[i] = invent.items[i] ;
        }
        for (int i = 0; i < 5; i++)
        {
             InventoryToNextScene.itemCount_inhotkey[i] =hkl.num[i] ;
           InventoryToNextScene.items_inhotkey[i] = hkl.item[i] ;
        }
        for (int i = 0; i < 6; i++)
        {
            InventoryToNextScene.armor[i] = pr.armor[i];
            
        }
    }
}
